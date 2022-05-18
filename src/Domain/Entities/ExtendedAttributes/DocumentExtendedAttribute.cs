using MinhasNoticias.Domain.Contracts;
using MinhasNoticias.Domain.Entities.Misc;

namespace MinhasNoticias.Domain.Entities.ExtendedAttributes
{
    public class DocumentExtendedAttribute : AuditableEntityExtendedAttribute<int, int, Document>
    {
    }
}