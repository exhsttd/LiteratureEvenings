using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Проект.Литературные_вечера.Data
{
    /// <summary>
    /// Класс (таблица) с колонками для информации о событии
    /// </summary>
    [Table("events", Schema = "public")]
    public class Event
    {
        /// <summary>
        /// Уникальный id события
        /// </summary>
        [Key]
        [Column("event_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid EventId { get; set; }

        /// <summary>
        /// Название события
        /// </summary>
        [Required]
        [Column("title")]
        [MaxLength(100)]
        public string Title { get; set; }

        /// <summary>
        /// Описание события
        /// </summary>
        [Column("description")]
        [MaxLength(500)]
        public string Description { get; set; }

        /// <summary>
        /// Дата проведения события
        /// </summary>
        [Required]
        [Column("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Время проведения события
        /// </summary>
        [Required]
        [Column("time")]
        public TimeSpan Time { get; set; }

        /// <summary>
        /// Категория события
        /// </summary>
        [Required]
        [Column("category")]
        [MaxLength(50)]
        public string Category { get; set; }
    }
}
