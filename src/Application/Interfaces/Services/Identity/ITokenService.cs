using MinhasNoticias.Application.Interfaces.Common;
using MinhasNoticias.Application.Requests.Identity;
using MinhasNoticias.Application.Responses.Identity;
using MinhasNoticias.Shared.Wrapper;
using System.Threading.Tasks;

namespace MinhasNoticias.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}