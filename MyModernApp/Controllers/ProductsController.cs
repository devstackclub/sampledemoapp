using Microsoft.AspNetCore.Mvc;
using MyModernApp.Models;

namespace MyModernApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products =
        [
            new Product { Id = 1, Name = "Laptop", Price = 75000m, Category = "Electronics" },
            new Product { Id = 2, Name = "Chair", Price = 2500m, Category = "Furniture" }
        ];

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Ok(Products);
        }
    }
}
