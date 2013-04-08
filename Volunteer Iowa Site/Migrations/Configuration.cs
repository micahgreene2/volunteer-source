namespace Volunteer_Iowa_Site.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Volunteer_Iowa_Site.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Volunteer_Iowa_Site.Models.EventDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Volunteer_Iowa_Site.Models.EventDataContext context)
        {
            context.Events.AddOrUpdate(i => i.eventID,
                new Event
                {
                    eventID = 1,
                    Name = "Default Event",
                    startDate = DateTime.Parse("01-01-2001"),
                    endDate = DateTime.Parse("01-01-2001"),
                    addressID = 1
                });

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
        }
    }
}
