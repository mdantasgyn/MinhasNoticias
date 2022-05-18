using AutoMapper;
using MinhasNoticias.Application.Features.Documents.Commands.AddEdit;
using MinhasNoticias.Application.Features.Documents.Queries.GetById;
using MinhasNoticias.Domain.Entities.Misc;

namespace MinhasNoticias.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}