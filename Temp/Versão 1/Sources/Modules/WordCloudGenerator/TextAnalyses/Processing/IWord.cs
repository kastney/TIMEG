using System;

namespace Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Processing
{
    public interface IWord : IComparable<IWord>
    {
        string Text { get; }
        int Occurrences { get; }
        string GetCaption();
    }
}