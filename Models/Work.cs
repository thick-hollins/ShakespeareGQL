using System.ComponentModel.DataAnnotations;

namespace ShakespeareGQL.Models
{
    public class Work
    {
      [Key]
      public string WorkId { get; set; }

      [Required]
      public string Title { get; set; }

      [Required]
      public string LongTitle { get; set; }

      [Required]
      public int Date { get; set; }
      
      [Required]
      public string GenreType { get; set; }
      
      public string Notes { get; set; }

      [Required]
      public string Source { get; set; }

      [Required]
      public int TotalWords { get; set; }

      [Required]
      public int TotalParagraphs { get; set; }
    }
} 