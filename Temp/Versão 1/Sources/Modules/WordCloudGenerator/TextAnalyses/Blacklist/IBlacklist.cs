namespace Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Blacklist
{
    public interface IBlacklist
    {
        bool Countains(string word);
        int Count { get; }
    }
}
