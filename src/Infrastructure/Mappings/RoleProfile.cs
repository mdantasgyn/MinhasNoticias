using AutoMapper;
using MinhasNoticias.Infrastructure.Models.Identity;
using MinhasNoticias.Application.Responses.Identity;

namespace MinhasNoticias.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, AppRole>().ReverseMap();
        }
    }
}