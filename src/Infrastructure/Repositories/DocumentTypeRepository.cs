using MinhasNoticias.Application.Interfaces.Repositories;
using MinhasNoticias.Domain.Entities.Misc;

namespace MinhasNoticias.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IRepositoryAsync<DocumentType, int> _repository;

        public DocumentTypeRepository(IRepositoryAsync<DocumentType, int> repository)
        {
            _repository = repository;
        }
    }
}