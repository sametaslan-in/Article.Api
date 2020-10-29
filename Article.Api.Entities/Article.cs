using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Article_Api.Entities
{
    public class Article
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int Id { get; set; }
       
        [Required]
        public string Title { get; set; }
       
        [Required]
        public string Text { get; set; }
        
        [Required]
        public int TextCount { get; set; }


    }
}
