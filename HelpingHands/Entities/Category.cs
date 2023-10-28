namespace HelpingHands.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
        public List<Ong> Ongs { get; set; }
    }
}
