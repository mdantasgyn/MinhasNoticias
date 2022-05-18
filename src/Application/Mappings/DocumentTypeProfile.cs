using AutoMapper;
using MinhasNoticias.Application.Features.DocumentTypes.Commands.AddEdit;
using MinhasNoticias.Application.Features.DocumentTypes.Queries.GetAll;
using MinhasNoticias.Application.Features.DocumentTypes.Queries.GetById;
using MinhasNoticias.Domain.Entities.Misc;

namespace MinhasNoticias.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}