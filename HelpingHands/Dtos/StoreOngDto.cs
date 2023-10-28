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
        [MaxLength(100)]
        public string ONGDescription { get; set; }

        public string Address { get; set; }

        public string Number { get; set; }

        public string Ocupation { get; set; }
    }
}
