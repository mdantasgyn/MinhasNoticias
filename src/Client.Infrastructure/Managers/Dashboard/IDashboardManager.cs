using MinhasNoticias.Shared.Wrapper;
using System.Threading.Tasks;
using MinhasNoticias.Application.Features.Dashboards.Queries.GetData;

namespace MinhasNoticias.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}