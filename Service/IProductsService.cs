using WebApiCRUD.Domain;
using WebApiCRUD.Interfaces;

namespace WebApiCRUD.Service
{
    public interface IProductsService
    {
        Product Add(Product product);
        IEnumerable<Product> GetAll();

        Product Get(long id);

        Product Update(Product product);

        bool Delete(Product product);

        bool CheckIfExists(long id);
    }
}
