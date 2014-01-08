namespace WebSite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebSite.Models;

    internal sealed class Configuration 
        : DbMigrationsConfiguration<WebSite.Models.LunchBoxDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebSite.Models.LunchBoxDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Sessions.AddOrUpdate(
                p => p.Title,
                    new LunchBoxSession { Title = "January 2014 - Brett Gordon", StartTime = new DateTime(2014, 01, 16, 12, 00, 00) }
                );
        }
    }
}
