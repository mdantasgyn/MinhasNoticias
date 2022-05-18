using MinhasNoticias.Application.Features.Documents.Commands.AddEdit;
using MinhasNoticias.Application.Features.Documents.Queries.GetAll;
using MinhasNoticias.Application.Requests.Documents;
using MinhasNoticias.Shared.Wrapper;
using System.Threading.Tasks;
using MinhasNoticias.Application.Features.Documents.Queries.GetById;

namespace MinhasNoticias.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}