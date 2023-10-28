using HelpingHands.Entities;
using System.ComponentModel.DataAnnotations;

namespace HelpingHands.Dtos
{
    public class GetOngDetailsDto
    {
        public int Id { get; set; }

        public List<Post>? Posts { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }

        
        public long x { get; set; }
        
        public long y { get; set; }

        
        public string ONGDescription { get; set; }
        
        public string Address { get; set; }
        
        public string Number { get; set; }
        
        public string Ocupation { get; set; }

        public List<Review>? Reviews { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
