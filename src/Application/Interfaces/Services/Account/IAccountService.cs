using MinhasNoticias.Application.Interfaces.Common;
using MinhasNoticias.Application.Requests.Identity;
using MinhasNoticias.Shared.Wrapper;
using System.Threading.Tasks;

namespace MinhasNoticias.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}