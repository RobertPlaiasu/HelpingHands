using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HelpingHands.Entities
{
    public class Ong
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Post> Posts { get; set; }
        [Required]
        
        public string Image { get; set; }

        [Required]
        public long x { get; set; }
        [Required]
        public long y { get; set; }

        [Required]
        public string ONGDescription { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Ocupation { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        
        public List<Review>? Reviews { get; set; }
        public int CategoryId { get; set; } 
        public Category Category { get; set; }
    }
}
