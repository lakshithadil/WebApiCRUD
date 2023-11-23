using WebApiCRUD.Domain;

namespace WebApiCRUD.Data
{
    public interface IProductsRepository
    {
        Product Add(Product product);
        IQueryable<Product> GetAll();

        Product Get(long id);

        Product Update(Product product);

        bool Delete(Product product);

        bool ProductExists(long id);
    }
}
