using AutoMapper;
using DenemeWeb.Models;
using DenemeWeb.Dto;
namespace DenemeWeb.Profiles
{
    public class CategoryNewDtoProfile : Profile
    {
        public CategoryNewDtoProfile()
        {

            CreateMap<Category, CategoryNewDto>();
               


        }
    }
}