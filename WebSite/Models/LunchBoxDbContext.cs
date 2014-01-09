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
        /// <summary>
        /// Initializes a new instance of the LunchBoxDbContext class.
        /// </summary>
        public LunchBoxDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<LunchBoxSession> Sessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LunchBoxDbContext, Configuration>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
