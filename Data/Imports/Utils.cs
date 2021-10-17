using System.IO;
using System.Web;

namespace ShakespeareGQL.Data.Imports
{
    public static class Utils
    {
        public static string Decode(string encoded)
        {
            StringWriter writer = new();
            HttpUtility.HtmlDecode(encoded, writer);
            return writer.ToString();
        }
    }
}