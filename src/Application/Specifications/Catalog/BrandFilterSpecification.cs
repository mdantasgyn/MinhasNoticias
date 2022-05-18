using MinhasNoticias.Application.Specifications.Base;
using MinhasNoticias.Domain.Entities.Catalog;

namespace MinhasNoticias.Application.Specifications.Catalog
{
    public class BrandFilterSpecification : SpecificationBase<Brand>
    {
        public BrandFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.Name.Contains(searchString) || p.Description.Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}
