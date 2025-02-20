using System;
using System.ComponentModel.DataAnnotations;

namespace StickyNotesAPIG.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public required string UserId { get; set; } // לזיהוי המשתמש שיצר את הפתק
    }
}