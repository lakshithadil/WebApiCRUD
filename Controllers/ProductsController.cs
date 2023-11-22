using Microsoft.AspNetCore.Mvc;
using WebApiCRUD.Service;

namespace WebApiCRUD.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    { 
    private readonly IProductsService _productsService;

    public ProductsController(IProductsService productsService)
    {
        this._productsService = productsService;
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        var products = _productsService.GetAll();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public IActionResult GetProduct(long id, [FromServices] ILogger<ProductsController> logger)
    {
        logger.LogDebug("GetProduct Action Invoked");
        var productToReturn = _productsService.Get(id);
        if (productToReturn == null)
        {
            return NotFound();
        }
        return Ok(productToReturn);
        }

    /*[HttpPost]
    public void SaveProduct([FromBody] Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    [HttpPut]
    public void UpdateProduct([FromBody] Product product)
    {
        _context.Products.Update(product);
        _context.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void DeleteProduct(long id)
    {
        _context.Products.Remove(new Product() { Id = id });
        _context.SaveChanges();
    }*/
    }
}
