using WebApiCRUD.Data;
using WebApiCRUD.Domain;

namespace WebApiCRUD.Service
{

    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public Product Add(Product product)
        {
            return _productsRepository.Add(product);
        }
        public bool CheckIfExists(long id)
        {
            return _productsRepository.ProductExists(id);
        }
        public bool Delete(Product product)
        {
            return _productsRepository.Delete(product);
        }
        public Product Get(long id)
        {
            return _productsRepository.Get(id);
        }
        public IEnumerable<Product> GetAll()
        {
            var speakers = _productsRepository.GetAll();
            return speakers;
        }
    
        public Product Update(Product product)
        {
            return _productsRepository.Update(product);
        }
    }
}
