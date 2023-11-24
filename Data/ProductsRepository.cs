using WebApiCRUD.Domain;
using WebApiCRUD.Interfaces;

namespace WebApiCRUD.Data
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly DataContext _context;
        private readonly IProductFactory _productFactory;

        public ProductsRepository(DataContext context, IProductFactory productFactory)
        {
            _context = context;
            _productFactory = productFactory;
        }

        public Product Add(Product product)
        {
            var addedItem = _context.Add(product).Entity;
            _context.SaveChanges();
            return addedItem;
        }

        public bool ProductExists(long id)
        {
            return _context.Products.Find(id) != null;
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Products.AsQueryable();
        }

        public Product Get(long id)
        {
            return _context.Products.Find(id);
        }

        public bool Delete(Product speaker)
        {
            var deleted = _context.Products.Remove(speaker);
            _context.SaveChanges();
            return true;
        }

        public Product Update(Product speaker)
        {
            var updatedEntity = _context.Products.Update(speaker).Entity;
            _context.SaveChanges();
            return updatedEntity;
        }

    }
}
