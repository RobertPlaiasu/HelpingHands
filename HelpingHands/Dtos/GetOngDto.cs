using HelpingHands.Entities;
using System.ComponentModel.DataAnnotations;

namespace HelpingHands.Dtos
{
    public class GetOngDto
    {
        
        public int Id { get; set; }
        

        public string Image { get; set; }
        public long x { get; set; }
        
        public long y { get; set; }
        public string ONGDescription { get; set; }
       
        public string Address { get; set; }
        
        public string Number { get; set; }
        
        public string Ocupation { get; set; }
       
        
        public int CategoryId { get; set; }
    }
}
