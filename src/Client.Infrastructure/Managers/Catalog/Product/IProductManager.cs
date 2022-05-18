using MinhasNoticias.Application.Features.Products.Commands.AddEdit;
using MinhasNoticias.Application.Features.Products.Queries.GetAllPaged;
using MinhasNoticias.Application.Requests.Catalog;
using MinhasNoticias.Shared.Wrapper;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}