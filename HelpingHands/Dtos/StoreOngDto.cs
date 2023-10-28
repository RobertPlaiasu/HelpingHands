using System.ComponentModel.DataAnnotations;

namespace HelpingHands.Dtos
{
    public class StoreOngDto
    {
        [Required(ErrorMessage ="Numele nu a fost gasit")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email ul nu a fost gasit")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Coordonata x nu a fost gasit")]
        public long x { get; set; }
        [Required(ErrorMessage = "Coordonata y nu a fost gasit")]
        public long y { get; set; }
        [Required(ErrorMessage = "Descrierea Ong nu a fost gasita")]
        [MaxLength(1000,ErrorMessage ="Descrietere poate sa aiba maxim 100 caracactere" )]
        public string ONGDescription { get; set; }
        [Required(ErrorMessage = "Adresa Ong nu a fost gasita")]
        [MaxLength(50, ErrorMessage = "Adresa poate sa aiba maxim 50 caracatere")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Numarul Ong nu a fost gasita")]
        [MaxLength(50, ErrorMessage = "Numarul ONG poate sa aiba maxim 50 caracatere")]
        public string Number { get; set; }
        [Required(ErrorMessage = "Ocupatia Ong nu a fost gasita")]
        [MaxLength(50, ErrorMessage = "Ocupatia poate sa aiba maxim 50 caracatere")]
        public string Ocupation { get; set; }
        public string Image { get; set; } = string.Empty;
    }
}
