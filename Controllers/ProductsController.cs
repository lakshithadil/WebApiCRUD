using Microsoft.AspNetCore.Mvc;
using WebApiCRUD.Models;

namespace WebApiCRUD.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return new Product[]
            {
                new Product() { Name = "Product 1" },
                new Product() { Name = "Product 2" },

            };
        }

        [HttpGet("{id}")]
        public Product GetProduct()
        {
            return new Product()
            {
                Id = 1,
                Name = "Test Product"
            };
        }
    }
}
