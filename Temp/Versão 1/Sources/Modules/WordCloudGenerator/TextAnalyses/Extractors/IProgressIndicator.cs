namespace Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Extractors
{
    public interface IProgressIndicator
    {
        int Maximum { get; set; }
        void Increment(int value);
    }
}
