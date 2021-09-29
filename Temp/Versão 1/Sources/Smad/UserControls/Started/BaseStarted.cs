using System.Windows.Forms;
using System.ComponentModel;
using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace Smad.UserControls.Started {

    public delegate void InstantiateHandler(object value);
    public delegate void NextHandler(Control control);
    public delegate void BackHandler();

    [ToolboxItem(false)]
    public partial class BaseStarted : UserControl {

        public InstantiateHandler InstantiateHandler { get; set; }
        public NextHandler NextHandler { get; set; }
        public BackHandler BackHandler { get; set; }

        public BaseStarted() => InitializeComponent();

        public virtual void SetColors(DockContentColorPalette colorPalette) { }
        public virtual void UpdateContent() { }
    }
}