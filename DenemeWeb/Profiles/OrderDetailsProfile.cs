using AutoMapper;
using DenemeWeb.Models;
using DenemeWeb.Dto;
namespace DenemeWeb.Profiles
{
    public class OrderDetailsProfile:Profile
    {
        public OrderDetailsProfile()
        {
            CreateMap<Customer, CustomerReadDto>();
            CreateMap<Order, OrderReadDto>();
            CreateMap<OrderDetailsReadDto, OrderDetails>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.SiparisId, opt => opt.MapFrom(src => src.SiparisId))
                .ForMember(dest => dest.YemekId, opt => opt.MapFrom(src => src.YemekId))
                .ForMember(dest => dest.Adet, opt => opt.MapFrom(src => src.Adet))
                .ForMember(dest => dest.Tutar, opt => opt.MapFrom(src => src.Tutar));

        }
    }
}
