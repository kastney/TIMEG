namespace Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Stemmers
{
    public interface IWordStemmer
    {
        string GetStem(string word);
    }
}
