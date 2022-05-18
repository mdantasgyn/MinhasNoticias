using MinhasNoticias.Application.Responses.Identity;
using MinhasNoticias.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using MinhasNoticias.Application.Interfaces.Chat;
using MinhasNoticias.Application.Models.Chat;

namespace MinhasNoticias.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}