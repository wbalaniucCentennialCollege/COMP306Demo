namespace COMP306Demo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using COMP306Demo.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<COMP306Demo.Models.COMP306DemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(COMP306Demo.Models.COMP306DemoContext context)
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



            context.Games.AddOrUpdate(x => x.Id,
                new Game() { Id = 1, Title = "Destiny 2", Genre = "FPS", Price = 60, Year = 2017 },
                new Game() { Id = 2, Title = "Playerunknown's Battleground", Genre = "FPS", Price = 60, Year = 2017 },
                new Game() { Id = 3, Title = "Super Mario 3", Genre = "Side-Scroller", Price = 50, Year = 1988 }
            );
        }
    }
}
