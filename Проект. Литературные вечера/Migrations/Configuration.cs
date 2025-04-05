namespace Проект.Литературные_вечера.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Проект.Литературные_вечера.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; 
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(Проект.Литературные_вечера.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
