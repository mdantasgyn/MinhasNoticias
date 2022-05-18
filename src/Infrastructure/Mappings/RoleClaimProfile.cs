using AutoMapper;
using MinhasNoticias.Application.Requests.Identity;
using MinhasNoticias.Application.Responses.Identity;
using MinhasNoticias.Infrastructure.Models.Identity;

namespace MinhasNoticias.Infrastructure.Mappings
{
    public class RoleClaimProfile : Profile
    {
        public RoleClaimProfile()
        {
            CreateMap<RoleClaimResponse, AppRoleClaim>()
                .ForMember(nameof(AppRoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(AppRoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();

            CreateMap<RoleClaimRequest, AppRoleClaim>()
                .ForMember(nameof(AppRoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(AppRoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();
        }
    }
}