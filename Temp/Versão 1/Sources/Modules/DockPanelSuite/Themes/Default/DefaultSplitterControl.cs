using LiveShowStudio.Modules.DockPanelSuite.Docking;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LiveShowStudio.Modules.DockPanelSuite.Themes.Default {

    [ToolboxItem(false)]
    internal class DefaultSplitterControl : DockPane.SplitterControlBase {

        private readonly SolidBrush _horizontalBrush;
        private int SplitterSize { get; }

        public DefaultSplitterControl(DockPane pane)
            : base(pane) {
            _horizontalBrush = pane.DockPanel.Theme.PaintingService.GetBrush(pane.DockPanel.Theme.ColorPalette.MainWindowActive.Background);
            SplitterSize = pane.DockPanel.Theme.Measures.SplitterSize;
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            Rectangle rect = ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0)
                return;

            switch (Alignment) {
                case DockAlignment.Right:
                case DockAlignment.Left: {
                    Debug.Assert(SplitterSize == rect.Width);
                    e.Graphics.FillRectangle(_horizontalBrush, rect);
                }
                break;
                case DockAlignment.Bottom:
                case DockAlignment.Top: {
                    Debug.Assert(SplitterSize == rect.Height);
                    e.Graphics.FillRectangle(_horizontalBrush, rect);
                }
                break;
            }
        }
    }
}