using CsvHelper.Configuration.Attributes;

namespace ShakespeareGQL.Data.Imports
{
    public class WordFormImport
    {
      public string WordFormId { get; set; }

      public string PlainText { get; set; }

      [Ignore]
      public string PhoneticText { get; set; }

      [Ignore]
      public string StemText { get; set; }
      
      public int Occurences { get; set; }
    }
}