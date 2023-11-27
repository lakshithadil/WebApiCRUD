using AutoMapper;
using WebApiCRUD.Concrete;
using WebApiCRUD.Domain;
using WebApiCRUD.Interfaces;
using WebApiCRUD.Models;

namespace WebApiCRUD.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductModel>().ReverseMap();
            CreateMap<ProductModel, Product>().ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<IProduct, ProductModel>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(dest => dest.Name, opt => opt.Ignore())
                .ForMember(dest => dest.Description, opt => opt.Ignore())
                .ForMember(dest => dest.Price, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
