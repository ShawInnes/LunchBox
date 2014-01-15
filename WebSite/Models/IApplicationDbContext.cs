using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace WebSite.Models
{
    public interface IApplicationDbContext<TUser> where TUser : Microsoft.AspNet.Identity.EntityFramework.IdentityUser
    {
        IDbSet<IdentityRole> Roles { get; set; }
        IDbSet<TUser> Users { get; set; }
    }
}
