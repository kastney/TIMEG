using Smad.Entities;
using Smad.UserControls.Settings;
using System.Collections.Generic;
using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace Smad.Pages {

    public partial class SettingsPage : DockContent {

        public SettingsPage() {
            InitializeComponent();

            OptionsListView.Objects = new List<Option> {
                new Option("Geral", new GeneralSetting())
            };
            OptionsListView.SelectedIndex = 0;
        }

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Control;
            OptionsListView.ForeColor = colorPalette.TextColor;
            OptionsListView.BackColor = colorPalette.Background;
            foreach (Option option in OptionsListView.Objects) option.Content.SetColors(colorPalette);
        }

        private void OptionsListView_SelectionChanged(object sender, System.EventArgs e) {
            if (OptionsListView.SelectedObject is Option option) {
                ContentPanel.Controls.Clear();
                ContentPanel.Controls.Add(option.Content);
            }
        }
    }
}