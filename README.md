# 🚀 ECommerce API – .NET 9 + JWT + EF Core + SQL Server

A clean and modular E-Commerce REST API built with **.NET 9**, **Entity Framework Core**, **JWT Authentication**, and **SQL Server**, designed for learning modern backend development with secure API practices.

---

# 📌 Project Overview

This project is a fully functional backend API demonstrating real-world e-commerce functionality.

---

## 🔐 Authentication & Authorization

- Register users with hashed passwords (BCrypt)
- Login with email + password
- Generate secure JWT tokens
- Restrict protected routes using `[Authorize]`
- Supports role-based authorization (Admin / User ready)
- JWT validation middleware configured

---

## 🛒 Core E-Commerce Modules Implemented

- User Registration & Login
- Product CRUD (secured with JWT)
- JWT Token Validation
- SQL Server relational database
- EF Core Code-First Migrations
- Clean controller + service + data architecture

---

## 📘 Swagger API Documentation

Interactive API testing with Swagger UI.

You can:
- Test endpoints with/without JWT token  
- Login → copy token → Authorize → run secured APIs

Swagger URL: https://localhost:7082/swagger


---

# 🛠 Tech Stack

| Layer | Technology |
|------|------------|
| **Backend** | ASP.NET Core 9 Web API |
| **Authentication** | JWT Bearer Tokens, BCrypt |
| **Database** | SQL Server |
| **ORM** | Entity Framework Core 9 |
| **Documentation** | Swagger / OpenAPI |
| **IDE** | Visual Studio 2022 / VS Code |

---

# 📂 Folder Structure
ECommerceSolution/
│
└── ECommerce.Api/
├── Controllers/
│ ├── AuthController.cs
│ └── ProductController.cs
│
├── Data/
│ └── AppDbContext.cs
│
├── DTOs/
│ ├── LoginRequest.cs
│ └── RegisterRequest.cs
│
├── Helpers/
│ └── JwtTokenGenerator.cs
│
├── Migrations/
│ └── (EF Core auto-generated files)
│
├── Models/
│ ├── User.cs
│ ├── Product.cs
│ ├── Cart.cs
│ ├── CartItem.cs
│ ├── Order.cs
│ └── OrderItem.cs
│
├── Services/
│ ├── AuthService.cs
│ └── ProductService.cs
│
├── Properties/
│ └── launchSettings.json
│
├── appsettings.json (ignored in Git)
└── Program.cs
