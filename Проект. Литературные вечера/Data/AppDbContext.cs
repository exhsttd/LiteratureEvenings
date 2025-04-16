
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Проект.Литературные_вечера.Data
{
    /// <summary>
    /// Контекст базы данных приложения для работы с литературными событиями
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Коллекция событий (мероприятий) в базе данных
        /// </summary>
        public DbSet<Event> Events { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр контекста базы данных
        /// </summary>
        public AppDbContext() : base("name=PostgresConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .Property(e => e.EventId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}

