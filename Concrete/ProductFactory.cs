using WebApiCRUD.Interfaces;

namespace WebApiCRUD.Concrete
{
    public class ProductFactory : IProductFactory
    {
        public IProduct CreateProduct(string productType)
        {
            switch (productType.ToLower())
            {
                case "standard":
                    return new StandardProduct();
                case "economy":
                    return new EconomyProduct();
                case "luxury":
                    return new LuxuryProduct();
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }
    }
}
