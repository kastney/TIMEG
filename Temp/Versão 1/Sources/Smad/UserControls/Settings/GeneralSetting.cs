using LiveShowStudio.Modules.DockPanelSuite.Docking;
using Smad.Pages;

namespace Smad.UserControls.Settings {

    public partial class GeneralSetting : BaseSetting {

        public GeneralSetting() {
            InitializeComponent();
            ThemeOptions.SelectedIndex = MasterPage.LayoutManager.GetTheme() is LightTheme ? 0 : 1;
        }

        public override void SetColors(DockContentColorPalette colorPalette) {
            GeneralGroup.ForeColor = colorPalette.TextColor;
            ThemeOptions.BackColor = colorPalette.Background;
            ThemeOptions.ForeColor = colorPalette.TextColor;
        }

        private void ThemeOptions_SelectedIndexChanged(object sender, System.EventArgs e) {
            if (ThemeOptions.SelectedIndex == 0) {
                MasterPage.LayoutManager.SetTheme("Light");
            } else {
                MasterPage.LayoutManager.SetTheme("Dark");
            }
        }
    }
}