using HelpingHands.Entities;
using System.ComponentModel.DataAnnotations;

namespace HelpingHands.Dtos
{
    public class GetUserDto
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        
        public string Name { get; set;}
        public int Exp { get; set; }
        public int Level { get; set; }
        public int OngId {  get; set; }
        public GetOngDto? Ong { get; set; }
        
    }
}
