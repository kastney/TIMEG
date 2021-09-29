using LiveShowStudio.Modules.DockPanelSuite.Docking;
using LiveShowStudio.Modules.ObjectListView;
using Smad.Dialogs;
using Smad.Entities;
using System.Drawing;

namespace Smad.Panels {

    public partial class ApplicationsPanel : DockContent {

        public ApplicationsPanel() => InitializeComponent();

        private void ApplicationsPanel_Load(object sender, System.EventArgs e) {
            var textOverlay = ListView.EmptyListMsgOverlay as TextOverlay;
            textOverlay.Font = new Font("Microsoft Sans Serif", 8);
            textOverlay.BorderWidth = 0;

            ListViewName.ImageGetter = delegate (object row) {
                return new Bitmap(((App)row).Icon, new Size(40, 40));
            };
        }

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
            ListView.BackColor = colorPalette.Background;
            ListView.ForeColor = colorPalette.TextColor;
            ListView.UnfocusedSelectedBackColor = SystemColors.Highlight;
            ListView.UnfocusedSelectedForeColor = colorPalette.TextColor;

            var textOverlay = ListView.EmptyListMsgOverlay as TextOverlay;
            textOverlay.BackColor = colorPalette.Background;
        }
        public override void SetStyle(ToolStripExtender style) {
            style.SetStyle(ToolStrip);
            style.SetStyle(GeneralContextMenuStrip);
            style.SetStyle(AppContextMenuStrip);
        }

        public override void UpdateContent() {
            if (Pages.MainPage.ObjectSerializeManager is null || Pages.MainPage.ObjectSerializeManager.Object is null) {
                Off();
            } else {
                On();
            }
        }
        private void On() {
            ToolStripAddApp.Enabled = true;
            GeneralContextMenuStrip.Enabled = true;

            Pages.MainPage.Index = -1;

            ListView.Objects = Pages.MainPage.ObjectSerializeManager.Object.Apps;
        }
        private void Off() {
            ToolStripAddApp.Enabled = false;
            GeneralContextMenuStrip.Enabled = false;

            ListView.Objects = null;
        }

        private void ListView_CellRightClick(object sender, CellRightClickEventArgs e) {
            e.MenuStrip = e.Item != null ? AppContextMenuStrip : GeneralContextMenuStrip;
        }
        private void ListView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if (ListView.SelectedIndex != -1) {
                if (e.KeyCode == System.Windows.Forms.Keys.Delete) {
                    RemoveApp_Click(null, null);
                }
            }
        }

        private void AddApp_Click(object sender, System.EventArgs e) {
            using (var dialog = Pages.MainPage.LayoutManager.OpenDialog<AddApplicationDialog>()) {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    Pages.MainPage.ObjectSerializeManager.Object.Apps.Add(dialog.App);
                    Pages.MainPage.ObjectSerializeManager.RegisterChanged();

                    ListView.Objects = Pages.MainPage.ObjectSerializeManager.Object.Apps;
                    ListView.SelectedIndex = Pages.MainPage.ObjectSerializeManager.Object.Apps.Count - 1;
                    ListView.FocusedItem = ListView.SelectedItem;
                    UpdatePanels();
                }
            }
        }
        private void RemoveApp_Click(object sender, System.EventArgs e) {
            if (System.Windows.Forms.MessageBox.Show($"Você tem certeza que remover o aplicativo \"{ListView.SelectedItem.Text}\"?", "Atenção", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes) {
                Pages.MainPage.ObjectSerializeManager.Object.Apps.RemoveAt(ListView.SelectedIndex);
                Pages.MainPage.ObjectSerializeManager.RegisterChanged();

                ListView.Objects = Pages.MainPage.ObjectSerializeManager.Object.Apps;
                UpdatePanels();
            }
        }
        private void ListView_SelectionChanged(object sender, System.EventArgs e) {
            if (ListView.SelectedIndex != -1) {
                UpdatePanels();
            }
        }

        private void UpdatePanels() {
            Pages.MainPage.Index = ListView.SelectedIndex;

            if (Pages.MainPage.LayoutManager.GetPanelByType<CommentsPanel>() is CommentsPanel commentsPanel) {
                commentsPanel.UpdateContent();
            }

            if (Pages.MainPage.LayoutManager.GetPanelByType<PropertiesPanel>() is PropertiesPanel propertiesPanel) {
                propertiesPanel.PropertyGrid.SelectedObject = Pages.MainPage.ObjectSerializeManager.Object.Apps[ListView.SelectedIndex];
                propertiesPanel.UpdateContent();
            }

            if (Pages.MainPage.LayoutManager.GetPanelByType<FilterPanel>() is FilterPanel filterPanel) {
                filterPanel.UpdateContent();
            }

            if (Pages.MainPage.LayoutManager.GetPanelByType<WordCloudPanel>() is WordCloudPanel wordCloudPanel) {
                wordCloudPanel.UpdateContent();
            }
        }
    }
}