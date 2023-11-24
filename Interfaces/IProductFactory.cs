namespace WebApiCRUD.Interfaces
{
    public interface IProductFactory
    {
        IProduct CreateProduct(string productType);
    }
}
