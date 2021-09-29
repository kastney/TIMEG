using System.Globalization;
using Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Stemmers;

namespace Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses
{
    public class NullStemmer : IWordStemmer
    {
        public string GetStem(string word)
        {
            return word.ToLower(CultureInfo.InvariantCulture);
        }
    }
}
