using System.ComponentModel.DataAnnotations;

namespace HelpingHands.Entities
{
    public class Need
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity {  get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
