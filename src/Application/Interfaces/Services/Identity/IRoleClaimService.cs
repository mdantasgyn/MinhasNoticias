using System.Collections.Generic;
using System.Threading.Tasks;
using MinhasNoticias.Application.Interfaces.Common;
using MinhasNoticias.Application.Requests.Identity;
using MinhasNoticias.Application.Responses.Identity;
using MinhasNoticias.Shared.Wrapper;

namespace MinhasNoticias.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}