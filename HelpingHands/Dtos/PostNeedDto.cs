using System.ComponentModel.DataAnnotations;

namespace HelpingHands.Dtos
{
    public class PostNeedDto
    {
        [Required(ErrorMessage = "Numele trebuie sa fie completat")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Cantitatea trebuie sa fie completat")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "PostId trebuie sa fie completat")]
        public int PostId { get; set; }
    }
}
