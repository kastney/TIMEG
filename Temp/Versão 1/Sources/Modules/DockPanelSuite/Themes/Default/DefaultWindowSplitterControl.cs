using LiveShowStudio.Modules.DockPanelSuite.Docking;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LiveShowStudio.Modules.DockPanelSuite.Themes.Default {

    [ToolboxItem(false)]
    public class DefaultWindowSplitterControl : SplitterBase {

        private SolidBrush _horizontalBrush;
        private readonly ISplitterHost _host;

        public DefaultWindowSplitterControl(ISplitterHost host) {
            _host = host;
        }

        protected override int SplitterSize {
            get { return _host.IsDockWindow ? _host.DockPanel.Theme.Measures.SplitterSize : _host.DockPanel.Theme.Measures.AutoHideSplitterSize; }
        }

        protected override void StartDrag() {
            _host.DockPanel.BeginDrag(_host, _host.DragControl.RectangleToScreen(Bounds));
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            Rectangle rect = ClientRectangle;

            if (rect.Width <= 0 || rect.Height <= 0)
                return;

            _horizontalBrush = _host.DockPanel.Theme.PaintingService.GetBrush(_host.DockPanel.Theme.ColorPalette.MainWindowActive.Background);
            if (_host.IsDockWindow) {
                switch (Dock) {
                    case DockStyle.Right:
                    case DockStyle.Left: {
                        Debug.Assert(SplitterSize == rect.Width);
                        e.Graphics.FillRectangle(_horizontalBrush, rect);
                    }
                    break;
                    case DockStyle.Bottom:
                    case DockStyle.Top: {
                        Debug.Assert(SplitterSize == rect.Height);
                        e.Graphics.FillRectangle(_horizontalBrush, rect);
                    }
                    break;
                }

                return;
            }

            switch (_host.DockState) {
                case DockState.DockRightAutoHide:
                case DockState.DockLeftAutoHide: {
                    Debug.Assert(SplitterSize == rect.Width);
                    e.Graphics.FillRectangle(_horizontalBrush, rect);
                }
                break;
                case DockState.DockBottomAutoHide:
                case DockState.DockTopAutoHide: {
                    Debug.Assert(SplitterSize == rect.Height);
                    e.Graphics.FillRectangle(_horizontalBrush, rect);
                }
                break;
            }
        }
    }
}