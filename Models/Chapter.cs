using System;
using System.ComponentModel.DataAnnotations;

namespace ShakespeareGQL.Models
{
    public class Chapter
    {
      [Key]
      public int ChapterId { get; set; }

      [Required]
      public int Act { get; set; }
      
      [Required]
      public int Scene { get; set; }
      
      public string Description { get; set; }


      [Required]
      public string WorkId { get; set; }

      public Work Work { get; set; }
    }
} 