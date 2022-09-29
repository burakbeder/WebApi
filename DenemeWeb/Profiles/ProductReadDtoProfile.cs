using AutoMapper;
using DenemeWeb.Models;
using DenemeWeb.Dto;
namespace DenemeWeb.Profiles
{
    public class ProductReadDtoProfile : Profile
    {
        public ProductReadDtoProfile()
        {
           
            CreateMap<Category, CategoryReadDto>().ReverseMap();
            CreateMap<Product, CategorytoFoodReadDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Ad, opt => opt.MapFrom(src => src.Ad))
                .ForMember(dest => dest.Fiyat, opt => opt.MapFrom(src => src.Fiyat))
                .ForMember(dest => dest.KategoriId, opt => opt.MapFrom(src => src.Kategori.Id))
                .ForMember(dest => dest.KategoriAd, opt => opt.MapFrom(src => src.Kategori.Kategori1));
            

          /*  CreateMap<KategoritoYemekReadDto, Yemek>()
                  .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dest => dest.Ad,opt => opt.MapFrom(src => src.Ad))
                  .ForMember(dest => dest.Fiyat, opt => opt.MapFrom(src => src.Fiyat))
                  .ForMember(dest => dest.Kategori.Id, opt => opt.MapFrom(src => src.KategoriId))
                  .ForMember(dest => dest.Restoran.Id, opt => opt.MapFrom(src => src.RestoranId));*/


        }
    }
}
