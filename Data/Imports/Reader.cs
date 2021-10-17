using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

namespace ShakespeareGQL.Data.Imports
{
    public class Reader<T>
    {
        public static List<T> Read(string filename)
        {
            string sFilePath = Path.GetFullPath($"./Data/{filename}.txt");
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Quote = '~'
            };
            using (var reader = new StreamReader(sFilePath))
            using (var csv = new CsvReader(reader, config))
            {
                return csv.GetRecords<T>().ToList();
            }
        }
    }
}