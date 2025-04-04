
using System.Data.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Проект.Литературные_вечера.Data
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext() : base("name=PostgresConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer<AppDbContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
        .Property(e => e.EventId)
        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            base.OnModelCreating(modelBuilder);
        }
    }
}

