using AutoMapper;
using WebApiCRUD.Domain;
using WebApiCRUD.Models;

namespace WebApiCRUD.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductModel>().ReverseMap();
            
        }
    }
}
