using System.Text.RegularExpressions;

namespace String_
{
    internal static class StringQueries
    {
        public static IEnumerable<string> GetUppercaseWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) yield break;

            // Split on whitespace and punctuation, keep words that contain letters and are equal to their uppercase form
            var words = Regex.Split(input, @"[\s,\.;:!?]+")
                .Where(w => !string.IsNullOrWhiteSpace(w))
                .Select(w => w.Trim());

            foreach (var w in words)
            {
                // Consider only pure word tokens containing letters/digits; treat punctuation-alone tokens as non-words
                if (w.All(char.IsLetter) && w == w.ToUpperInvariant())
                    yield return w;
            }
        }
    }
}