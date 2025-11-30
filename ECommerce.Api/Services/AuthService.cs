using BCrypt.Net;
using ECommerce.Api.Data;
using ECommerce.Api.DTOs;
using ECommerce.Api.Models;
using Microsoft.EntityFrameworkCore;
using ECommerce.Api.Helpers;


namespace ECommerce.Api.Services
{
    public class AuthService
    {
        private readonly AppDbContext _db;
        private readonly JwtTokenGenerator _jwt;

        public AuthService(AppDbContext db, JwtTokenGenerator jwt)
        {
            _db = db;
            _jwt = jwt;
        }

        // Register user
        public async Task<string> RegisterUser(RegisterRequest request)
        {
            // Check if email exists
            if (await _db.Users.AnyAsync(u => u.Email == request.Email))
                return "User already exists";

            var user = new User
            {
                UserName = request.UserName,
                Email = request.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
                Role = request.Role
            };

            _db.Users.Add(user);
            await _db.SaveChangesAsync();

            return "User registered successfully";
        }

        // Login user
        public async Task<string?> LoginUser(LoginRequest request)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == request.Email);

            if (user == null)
                return null;

            if (!BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
                return null;

            return _jwt.GenerateToken(user);
        }
    }
}
