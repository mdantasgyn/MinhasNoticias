using MinhasNoticias.Application.Models.Chat;
using MinhasNoticias.Application.Responses.Identity;
using MinhasNoticias.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using MinhasNoticias.Application.Interfaces.Chat;

namespace MinhasNoticias.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}