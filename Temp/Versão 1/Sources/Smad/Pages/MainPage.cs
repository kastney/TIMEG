using Smad.Dialogs;
using Smad.Entities;
using System.Windows.Forms;
using Smad.Modules.LayoutManager;
using Smad.Modules.ObjectSerialize;
using LiveShowStudio.Modules.DockPanelSuite.Docking;
using LiveShowStudio.Modules.ObjectSerializeManager;
using LiveShowStudio.Modules.DockPanelSuite.LayoutManager;
using Smad.Panels;

namespace Smad.Pages {

    public partial class MainPage : Form {

        public static int Index { get; set; } = -1;

        public static ObjectSerializeManager<Experiment, ObjectData> ObjectSerializeManager { get; private set; }
        public static LayoutManager<LayoutTheme, LayoutData> LayoutManager { get; private set; }

        #region Main Page
        public MainPage() {
            InitializeComponent();

            //Gerenciador do Layout e Tema
            LayoutManager = new LayoutManager<LayoutTheme, LayoutData>(DockPanel) {
                SetStyle = LayoutManager_SetStyle,
                DropDown = ToolStripLayouts
            };
            LayoutManager.Init();

            //Gerenciador da serialização de objetos.
            ObjectSerializeManager = new ObjectSerializeManager<Experiment, ObjectData> {
                FilterObject = "Arquivo do Smad|*.smad",
                IsSavedChanged = OptionsSaved,
                LoadedChanged = OptionsLoad,
                ClosedChanged = OptionsClosed,
                RecentOpenItem = MenuStripFileRecentOpen
            };

            NewProject();
        }
        private void MainPage_FormClosing(object sender, FormClosingEventArgs e) {
            if (!ObjectSerializeManager.CheckSaved()) {
                e.Cancel = true;
                return;
            }

            ObjectSerializeManager.Dispose();
            LayoutManager.Dispose();
        }
        #endregion

        #region Layout Manager
        private void LayoutManager_SetStyle(ToolStripExtender style) {
            style.SetStyle(MenuStrip);
            style.SetStyle(ToolStrip);
            style.SetStyle(StatusStrip);
            BackColor = DockPanel.Theme.ColorPalette.CommandBarMenuDefault.Background;
        }
        #endregion

        #region Object List View
        private void OptionsLoad() {
            MenuStripFileClose.Enabled = true;
            MenuStripFileSaveAs.Enabled = true;
            MenuStripFileSaveCopy.Enabled = true;

            LayoutManager.UpdateLayout();
        }
        private void OptionsUnload() {
            MenuStripFileClose.Enabled = false;
            MenuStripFileSaveAs.Enabled = false;
            MenuStripFileSaveCopy.Enabled = false;
        }
        private void OptionsSaved() {
            MenuStripFileSave.Enabled = ObjectSerializeManager.Object is null ? false : !ObjectSerializeManager.Object.IsSaved;
        }
        private void OptionsClosed() {
            //Reiniciando paineis
            //if (LayoutManager.GetPanelByType<CommentsPanel>() is CommentsPanel layersPanel)
            //Reiniciando layout
            LayoutManager.UpdateLayout();
        }
        #endregion

        #region Menu
        #region File
        private void MenuStripFileNew_Click(object sender, System.EventArgs e) {
            if (ObjectSerializeManager.CheckSaved()) {
                using (var dialog = LayoutManager.OpenDialog<NewExperimentDialog>()) {
                    if (dialog.ShowDialog() == DialogResult.OK) {
                        ObjectSerializeManager.NewObject(dialog.Experiment);
                    }
                }
            }
        }
        private void MenuStripFileOpen_Click(object sender, System.EventArgs e) {
            if (ObjectSerializeManager.CheckSaved()) {
                ObjectSerializeManager.OpenObject();
            }
        }
        private void MenuStripFileClose_Click(object sender, System.EventArgs e) {
            if (ObjectSerializeManager.CheckSaved()) {
                ObjectSerializeManager.CloseObject();
                OptionsUnload();
            }
        }
        private void MenuStripFileSave_Click(object sender, System.EventArgs e) => ObjectSerializeManager.SaveObject();
        private void MenuStripFileSaveAs_Click(object sender, System.EventArgs e) => ObjectSerializeManager.SaveAsObject();
        private void MenuStripFileSaveCopy_Click(object sender, System.EventArgs e) => ObjectSerializeManager.SaveCopyObject();
        private void MenuStripFileExit_Click(object sender, System.EventArgs e) => Application.Exit();
        #endregion
        #region Edit
        private void MenuStripEditSettings_Click(object sender, System.EventArgs e) => LayoutManager.OpenPage<SettingsPage>();
        #endregion
        #region Window
        private void MenuStripWindowApplications_Click(object sender, System.EventArgs e) => LayoutManager.OpenPanel<ApplicationsPanel>();
        private void MenuStripWindowApplicationsComments_Click(object sender, System.EventArgs e) => LayoutManager.OpenPanel<CommentsPanel>();
        private void MenuStripWindowFilters_Click(object sender, System.EventArgs e) => LayoutManager.OpenPanel<FilterPanel>();
        private void MenuStripWindowProperties_Click(object sender, System.EventArgs e) => LayoutManager.OpenPanel<PropertiesPanel>();
        private void MenuStripWindowWordCloud_Click(object sender, System.EventArgs e) => LayoutManager.OpenPanel<WordCloudPanel>();
        #endregion

        #endregion

        private void NewProject() {
            Hide();

            using (var startedPage = new StartedPage(LayoutManager, ObjectSerializeManager)) {
                startedPage.SetColors(LayoutManager.GetTheme().DockContentColorPalette);
                if (startedPage.ShowDialog() == DialogResult.OK) {
                    //LayoutManager.OpenPanel<ReportPanel>();
                    Show();
                } else {
                    Close();
                }
            }
        }
    }
}