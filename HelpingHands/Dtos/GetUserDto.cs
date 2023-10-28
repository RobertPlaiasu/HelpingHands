using System.ComponentModel.DataAnnotations;

namespace HelpingHands.Dtos
{
    public class GetUserDto
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        
        public string Password { get; set; } = string.Empty;
    }
}
