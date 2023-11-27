using WebApiCRUD.Interfaces;

namespace WebApiCRUD.Concrete
{
    public class EconomyProduct : IEconomyProduct
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; } = "Economy Product";
    }
}
