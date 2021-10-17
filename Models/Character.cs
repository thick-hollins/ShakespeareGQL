using System.ComponentModel.DataAnnotations;

namespace ShakespeareGQL.Models
{
    public class Character
    {
      [Required]
      public string CharacterName { get; set; }

      [Required]
      public string Abbrev { get; set; }

      [Key]
      public string CharacterId { get; set; }

      [Required]
      public string Works { get; set; }
      
      [Required]
      public int SpeechCount { get; set; }
      
      public string Description { get; set; }

    }
} 