using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebSite.Models
{
    public class LunchBoxDbContext
            : DbContext
    {
        public DbSet<LunchBoxSession> Sessions { get; set; }
    }
}
