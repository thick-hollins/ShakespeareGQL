namespace ShakespeareGQL.Data.Imports
{
    public class WorkImport
    {
      public string WorkId { get; set; }

      public string Title { get; set; }

      public string LongTitle { get; set; }

      public int Date { get; set; }
      
      public string GenreType { get; set; }
      
      public string Notes { get; set; }

      public string Source { get; set; }

      public int TotalWords { get; set; }

      public int TotalParagraphs { get; set; }
    }
}