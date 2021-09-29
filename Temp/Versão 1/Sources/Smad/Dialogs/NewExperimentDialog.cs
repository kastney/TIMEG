using Smad.Entities;
using System.Windows.Forms;
using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace Smad.Dialogs {

    public partial class NewExperimentDialog : DockContent {

        public Experiment Experiment { get; private set; }

        public NewExperimentDialog() => InitializeComponent();


        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
            PropertiesPanel.BackColor = colorPalette.Control;

            NameLiveText.BackColor = colorPalette.Background;
            NameLiveText.ForeColor = colorPalette.TextColor;
            NameLiveLabel.ForeColor = colorPalette.TextColor;

            CancelButton.ForeColor = colorPalette.TextColor;
            CreateButton.ForeColor = colorPalette.TextColor;
        }

        private void CreateButton_Click(object sender, System.EventArgs e) {
            Experiment = new Experiment {
                Name = NameLiveText.Text
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void NameLiveText_Leave(object sender, System.EventArgs e) {
            if (string.IsNullOrEmpty(NameLiveText.Text)) NameLiveText.Text = "Sem título";
        }
    }
}