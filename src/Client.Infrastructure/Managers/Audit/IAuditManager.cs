using MinhasNoticias.Application.Responses.Audit;
using MinhasNoticias.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Infrastructure.Managers.Audit
{
    public interface IAuditManager : IManager
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync();

        Task<IResult<string>> DownloadFileAsync(string searchString = "", bool searchInOldValues = false, bool searchInNewValues = false);
    }
}