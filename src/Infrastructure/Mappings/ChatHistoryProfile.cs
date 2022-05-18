using AutoMapper;
using MinhasNoticias.Application.Interfaces.Chat;
using MinhasNoticias.Application.Models.Chat;
using MinhasNoticias.Infrastructure.Models.Identity;

namespace MinhasNoticias.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<AppUser>>().ReverseMap();
        }
    }
}