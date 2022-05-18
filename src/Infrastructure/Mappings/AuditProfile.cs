using AutoMapper;
using MinhasNoticias.Infrastructure.Models.Audit;
using MinhasNoticias.Application.Responses.Audit;

namespace MinhasNoticias.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}