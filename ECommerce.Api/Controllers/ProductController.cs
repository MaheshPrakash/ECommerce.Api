using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ECommerce.Api.Services;
using ECommerce.Api.Models;

namespace ECommerce.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }

        // Anyone can view products
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _service.GetAllAsync();
            return Ok(products);
        }

        // Anyone can view a single product
        [HttpGet("{id:int}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _service.GetByIdAsync(id);
            if (product == null)
                return NotFound("Product not found");

            return Ok(product);
        }

        // Admin only — Create product
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            var created = await _service.AddAsync(product);
            return Ok(created);
        }

        // Admin only — Update product
        [HttpPut("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {
            var updated = await _service.UpdateAsync(id, product);
            if (updated == null)
                return NotFound("Product not found");

            return Ok(updated);
        }

        // Admin only — Delete product
        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted)
                return NotFound("Product not found");

            return Ok("Product deleted");
        }
    }
}
