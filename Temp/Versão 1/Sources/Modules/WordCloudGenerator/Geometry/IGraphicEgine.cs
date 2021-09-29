using System;
using System.Drawing;

namespace Nulo.WinForms.Control.WordCloudGenerator.Geometry
{
    public interface IGraphicEngine : IDisposable
    {
        SizeF Measure(string text, int weight);
        void Draw(LayoutItem layoutItem);
        void DrawEmphasized(LayoutItem layoutItem);
    }
}
