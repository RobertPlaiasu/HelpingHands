namespace HelpingHands.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string Text {  get; set; }
        public int numberStars { get; set; }
        public Ong Ong { get; set; }
        public int OngId { get; set; }
    }
}
