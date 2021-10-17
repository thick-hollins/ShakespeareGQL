using System;
using CsvHelper.Configuration.Attributes;

namespace ShakespeareGQL.Data.Imports
{
    public class ChapterImport
    {
        private string _description;

        public string WorkId { get; set; }
        public int ChapterId { get; set; }
        public int Act { get; set; }
        public int Scene { get; set; }
        public string Description 
        {
            get => _description;
            set
            {   
                if (value == "\"---\"")
                {
                    _description = null;
                }
                _description = Utils.Decode(value);
            }
        }
    }
}