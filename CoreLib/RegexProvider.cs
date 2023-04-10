using System.Text.RegularExpressions;

namespace CoreLib
{
    public class RegexProvider
    {
        public Regex CreateRegex()
        {
            return new Regex("[^a-zA-Z ]");
        }
    }
}