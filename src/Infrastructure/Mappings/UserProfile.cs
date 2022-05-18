using AutoMapper;
using MinhasNoticias.Infrastructure.Models.Identity;
using MinhasNoticias.Application.Responses.Identity;

namespace MinhasNoticias.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, AppUser>().ReverseMap();
            CreateMap<ChatUserResponse, AppUser>().ReverseMap()
                .ForMember(dest => dest.EmailAddress, source => source.MapFrom(source => source.Email)); //Specific Mapping
        }
    }
}