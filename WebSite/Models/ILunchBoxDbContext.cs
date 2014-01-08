using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebSite.Models
{
    public interface ILunchBoxDbContext
    {
        DbSet<LunchBoxSession> Sessions { get; set; }
    }
}
