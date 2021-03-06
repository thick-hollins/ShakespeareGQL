using CsvHelper.Configuration.Attributes;

namespace ShakespeareGQL.Data.Imports
{
    public class CharacterImport
    {
        public string CharacterName { get; set; }
        public string Abbrev { get; set; }
        public string CharacterId { get; set; }
        [Ignore]
        public string Works { get; set; }
        public int SpeechCount { get; set; }
        public string Description { get; set; }
    }
}