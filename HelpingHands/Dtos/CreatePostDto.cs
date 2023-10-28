using HelpingHands.Entities;
using System.ComponentModel.DataAnnotations;

namespace HelpingHands.Dtos
{
    public class CreatePostDto
    {
        [Required(ErrorMessage = "Nu exista titlu!")]
        [MaxLength(50, ErrorMessage = "Sutn mai mulde 50 de caractere!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Nu exista descriere!")]
        [MaxLength(1000, ErrorMessage = "Sunt mai mulde 1000 de caractere!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Nu exista ong!")]
        public int OngId { get; set; }
        [Required(ErrorMessage = "Nu exista categorie!")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Nu exista adresa!")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Nu exista judet!")]
        public string County { get; set; }
    }
}
