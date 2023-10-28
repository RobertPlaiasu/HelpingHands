using System.ComponentModel.DataAnnotations;

namespace HelpingHands.Dtos
{
    public class AuthUserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        public string Password { get; set; } = string.Empty;
    }
}
