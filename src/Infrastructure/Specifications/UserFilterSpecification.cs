using MinhasNoticias.Infrastructure.Models.Identity;
using MinhasNoticias.Application.Specifications.Base;

namespace MinhasNoticias.Infrastructure.Specifications
{
    public class UserFilterSpecification : SpecificationBase<AppUser>
    {
        public UserFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.FirstName.Contains(searchString) || p.LastName.Contains(searchString) || p.Email.Contains(searchString) || p.PhoneNumber.Contains(searchString) || p.UserName.Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}