using System;
using System.Collections.Generic;
using MinhasNoticias.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace MinhasNoticias.Infrastructure.Models.Identity
{
    public class AppRole : IdentityRole, IAuditableEntity<string>
    {
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual ICollection<AppRoleClaim> RoleClaims { get; set; }

        public AppRole() : base()
        {
            RoleClaims = new HashSet<AppRoleClaim>();
        }

        public AppRole(string roleName, string roleDescription = null) : base(roleName)
        {
            RoleClaims = new HashSet<AppRoleClaim>();
            Description = roleDescription;
        }
    }
}