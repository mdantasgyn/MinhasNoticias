using AutoMapper;
using MinhasNoticias.Application.Requests.Identity;
using MinhasNoticias.Application.Responses.Identity;

namespace MinhasNoticias.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}