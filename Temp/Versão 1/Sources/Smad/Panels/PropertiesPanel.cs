using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace Smad.Panels {

    public partial class PropertiesPanel : DockContent {

        public PropertiesPanel() => InitializeComponent();

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
            ForeColor = colorPalette.TextColor;

            PropertyGrid.BackColor = colorPalette.Control;

            PropertyGrid.ViewBackColor = colorPalette.Background;
            PropertyGrid.ViewBorderColor = colorPalette.Background;
            PropertyGrid.ViewForeColor = colorPalette.TextColor;

            PropertyGrid.CategoryForeColor = colorPalette.TextColor;
            PropertyGrid.LineColor = colorPalette.Background;

            PropertyGrid.HelpBackColor = colorPalette.Control;
            PropertyGrid.HelpBorderColor = colorPalette.Control;
            PropertyGrid.HelpForeColor = colorPalette.TextColor;
        }

        public override void UpdateContent() {
            ////Define o modo de exibição do painel de comentários.
            if (Pages.MainPage.ObjectSerializeManager is null || Pages.MainPage.ObjectSerializeManager.Object is null || Pages.MainPage.Index == -1) {
                PropertyGrid.Enabled = false;
                PropertyGrid.SelectedObject = null;
            } else {
                PropertyGrid.Enabled = true;
            }
        }
    }
}