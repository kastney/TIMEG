using LiveShowStudio.Modules.DockPanelSuite.Docking;
using System.ComponentModel;
using System.Windows.Forms;

namespace Smad.UserControls.Settings {

    [ToolboxItem(false)]
    public partial class BaseSetting : UserControl {

        public BaseSetting() {
            InitializeComponent();
        }

        public virtual void SetColors(DockContentColorPalette colorPalette) { }
    }
}