using System.Drawing;
using Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Processing;

namespace Nulo.WinForms.Control.WordCloudGenerator.Geometry
{
    public class LayoutItem
    {
        public LayoutItem(RectangleF rectangle, IWord word)
        {
            this.Rectangle = rectangle;
            Word = word;
        }

        public RectangleF Rectangle { get; private set; }
        public IWord Word { get; private set; }

        public LayoutItem Clone()
        {
            return new LayoutItem(this.Rectangle, this.Word);
        }
    }
}
