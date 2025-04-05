
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Проект.Литературные_вечера.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public AppDbContext() : base("name=PostgresConnection")
        {
            Configuration.LazyLoadingEnabled = false;
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

