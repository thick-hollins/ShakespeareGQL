using System.ComponentModel.DataAnnotations;

namespace ShakespeareGQL.Models
{
    public class WordForm
    {
      [Key]
      public string WordFormId { get; set; }

      [Required]
      public string PlainText { get; set; }
      
      [Required]
      public int Occurences { get; set; }
    }
} 