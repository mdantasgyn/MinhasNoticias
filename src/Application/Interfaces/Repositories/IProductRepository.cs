using System.Threading.Tasks;

namespace MinhasNoticias.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<bool> IsBrandUsed(int brandId);
    }
}