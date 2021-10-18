using System.ComponentModel.DataAnnotations;

namespace ShakespeareGQL.Models
{
    public class Paragraph
    {
      [Key]
      public int ParagraphId { get; set; }

      [Required]
      public string WorkId { get; set; }

      [Required]
      public int ParagraphNum { get; set; }

      [Required]
      public string CharId { get; set; }
      
      [Required]
      public string PlainText { get; set; }

      [Required]
      public string ParagraphType { get; set; }
      
      [Required]
      public int Act { get; set; }

      [Required]
      public int Scene { get; set; }

      [Required]
      public int CharCount { get; set; }

      [Required]
      public int WordCount { get; set; }
    }
} 