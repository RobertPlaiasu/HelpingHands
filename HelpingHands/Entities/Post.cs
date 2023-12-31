﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpingHands.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
        [Required]
        public int? OngId { get; set; }
        [ForeignKey("OngId")]
        public Ong? Ong { get; set; }
        [Required]
        public int CategoryId {  get; set; }
        [Required]
        public Category Category { get; set; }
        [Required]
        public string Image { get; set; } = string.Empty;
        [Required]
        public string? Address { get; set; }
        public string County { get; set; }
        public List<Need> Needs { get; set; }
    }
}
