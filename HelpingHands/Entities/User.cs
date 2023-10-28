using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HelpingHands.Entities
{
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [AllowNull]
        public byte[] PasswordHash { get; set; }
        [AllowNull]
        public byte[] PasswordSalt { get; set; }
        [AllowNull]
        public string RefreshToken { get; set; } = string.Empty;
        [AllowNull]
        public DateTime TokenCreated { get; set; }
        [AllowNull]
        public DateTime TokenExpires { get; set; }
        [DefaultValue(0)]
        public int Exp { get; set; }
        [DefaultValue(0)]
        public int Level { get; set; }
        [DefaultValue("user")]
        public string Role { get; set; } = "user";
        public Ong? Ong { get; set; }


    }
}
