using WebApiCRUD.Data;
using WebApiCRUD.Models;

namespace WebApiCRUD.Service
{
    
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public Product Add(Product product)
        {
            return productsRepository.Add(product);
        }
        public bool CheckIfExists(long id)
        {
            return productsRepository.ProductExists(id);
        }
        public bool Delete(Product product)
        {
            return productsRepository.Delete(product);
        }
        public Product Get(long id)
        {
            return productsRepository.Get(id);
        }
        public IEnumerable<Product> GetAll()
        {
            var speakers = productsRepository.GetAll();
            return speakers;
        }
    
        public Product Update(Product product)
        {
            return productsRepository.Update(product);
        }
    }
}
