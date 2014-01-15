using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace WebSite.Models
{
    public class ApplicationDbContext 
        : IdentityDbContext<ApplicationUser>, 
        IApplicationDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public override System.Data.Entity.IDbSet<ApplicationUser> Users
        {
            get
            {
                return base.Users;
            }
            set
            {
                base.Users = value;
            }
        }

        public override System.Data.Entity.IDbSet<IdentityRole> Roles
        {
            get
            {
                return base.Roles;
            }
            set
            {
                base.Roles = value;
            }
        }

    }
}
