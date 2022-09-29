using AutoMapper;
using DenemeWeb.Models;
using DenemeWeb.Dto;
namespace DenemeWeb.Profiles
{
    public class ProductCreateProfile : Profile
    {
        public ProductCreateProfile()
        {

            CreateMap<ProductPostDto, Product>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Ad, opt => opt.MapFrom(src => src.Ad))
                .ForMember(dest => dest.Fiyat, opt => opt.MapFrom(src => src.Fiyat))
                .ForMember(dest => dest.KategoriId, opt => opt.MapFrom(src => src.KategoriId));
            
        


        }
    }
}
