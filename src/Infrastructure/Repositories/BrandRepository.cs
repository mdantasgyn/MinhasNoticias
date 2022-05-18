using MinhasNoticias.Application.Interfaces.Repositories;
using MinhasNoticias.Domain.Entities.Catalog;

namespace MinhasNoticias.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}