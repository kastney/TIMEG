using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace Smad.Panels {

    public partial class ReportPanel : DockContent {

        public ReportPanel() {
            InitializeComponent();
        }

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
        }

        private void ReportPanel_Load(object sender, System.EventArgs e) {
            //BaseReportPanel.InforReportPanel.UpdateContent();
            //BaseReportPanel.InforReportPanel.SetColors();

            //BaseReportPanel.WordCloudReportPanel.UpdateContent();
            //BaseReportPanel.WordCloudReportPanel.SetColors();
        }
    }
}