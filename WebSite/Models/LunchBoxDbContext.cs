using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebSite.Migrations;

namespace WebSite.Models
{
    public class LunchBoxDbContext
            : DbContext, ILunchBoxDbContext
    {
        public DbSet<LunchBoxSession> Sessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LunchBoxDbContext, Configuration>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
