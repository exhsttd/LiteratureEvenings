using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Проект.Литературные_вечера.Data
{
    [Table("events", Schema = "public")]
    public class Event
    {
        [Key]
        [Column("event_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }

        [Required]
        [Column("title")]
        [MaxLength(100)]
        public string Title { get; set; }

        [Column("description")]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [Column("date")]
        public DateTime Date { get; set; }

        [Required]
        [Column("time")]
        public TimeSpan Time { get; set; }

        [Required]
        [Column("category")]
        [MaxLength(50)]
        public string Category { get; set; }
    }
}
