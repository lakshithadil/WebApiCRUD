using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApiCRUD.Domain;
using WebApiCRUD.Models;
using WebApiCRUD.Service;

namespace WebApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductsService _productsService;
        private readonly IMapper _mapper;

        public ProductsController(IProductsService productsService, IMapper mapper)
        {
            _productsService = productsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productsService.GetAll();
            var productModels = _mapper.Map<IEnumerable<ProductModel>>(products);
            return Ok(productModels);

        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(long id, [FromServices] ILogger<ProductsController> logger)
        {
            logger.LogDebug("GetProduct Action Invoked");
            var productToReturn = _productsService.Get(id);
            var productModel = _mapper.Map<ProductModel>(productToReturn);
            if (productModel == null)
            {
                return NotFound();
            }

            return Ok(productModel);
        }

        [HttpPost]
        public IActionResult SaveProduct(ProductModel model)
        {
            var productToAdd = _mapper.Map<Product>(model);
            _productsService.Add(productToAdd);

            return CreatedAtAction(nameof(GetProduct), new { id = productToAdd.Id }, model);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(long id, ProductModel model)
        {
            var productFromDb = _productsService.Get(id);
            if (productFromDb == null)
            {
                return NotFound();
            }

            TryUpdateModelAsync(productFromDb);
            _productsService.Update(productFromDb);
            return Ok(productFromDb);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(long id)
        {
            var productFromDb = _productsService.Get(id);
            if (productFromDb == null)
            {
                return NotFound();
            }

            _productsService.Delete(productFromDb);
            return NoContent();
        }
    }
}
