using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShakespeareGQL.Models
{
    public class Character
    {
      [Key]
      public string CharacterId { get; set; }

      [Required]
      public string CharacterName { get; set; }

      [Required]
      public string Abbrev { get; set; }
      
      [Required]
      public int SpeechCount { get; set; }
      
      public string Description { get; set; }


      public List<Paragraph> Paragraphs { get; set; }

    }
} 