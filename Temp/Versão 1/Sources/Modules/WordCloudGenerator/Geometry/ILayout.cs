using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Processing;

namespace Nulo.WinForms.Control.WordCloudGenerator.Geometry
{
    public interface ILayout
    {
        void Arrange(IEnumerable<IWord> words, IGraphicEngine graphicEngine);
        IEnumerable<LayoutItem> GetWordsInArea(RectangleF area);
    }
}