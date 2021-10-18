using CsvHelper.Configuration.Attributes;

namespace ShakespeareGQL.Data.Imports
{
    public class ParagraphImport
    {
      public int ParagraphId { get; set; }

      public string WorkId { get; set; }

      public int ParagraphNum { get; set; }

      public string CharId { get; set; }
      
      public string PlainText { get; set; }
      
      [Ignore]
      public string PhoneticText { get; set; }

      [Ignore]
      public string StemText { get; set; }

      public string ParagraphType { get; set; }

      public int Act { get; set; }

      public int Scene { get; set; }

      public int CharCount { get; set; }

      public int WordCount { get; set; }
    }
}