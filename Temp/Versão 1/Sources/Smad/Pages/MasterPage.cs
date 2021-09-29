using System;
using Smad.Entities;
using System.Windows.Forms;
using Smad.Modules.LayoutManager;
using Smad.Modules.ObjectSerialize;
using LiveShowStudio.Modules.ObjectSerializeManager;
using LiveShowStudio.Modules.DockPanelSuite.LayoutManager;
using LiveShowStudio.Modules.DockPanelSuite.Docking;
using Smad.Pages.Panels.Automatic;
using System.IO;

namespace Smad.Pages {

    public partial class MasterPage : Form {

        public static ObjectSerializeManager<Experiment, ObjectData> ObjectSerializeManager { get; private set; }
        public static LayoutManager<LayoutTheme, LayoutData> LayoutManager { get; private set; }

        public MasterPage() {
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

            //LayoutManager.SetTheme("Light");

            NewProject();
        }

        #region Object List View
        private void OptionsLoad() {
            //MenuStripFileClose.Enabled = true;
            //MenuStripFileSaveAs.Enabled = true;
            //MenuStripFileSaveCopy.Enabled = true;

            //LayoutManager.UpdateLayout();
        }
        private void OptionsUnload() {
            //MenuStripFileClose.Enabled = false;
            //MenuStripFileSaveAs.Enabled = false;
            //MenuStripFileSaveCopy.Enabled = false;
        }
        private void OptionsSaved() {
            //MenuStripFileSave.Enabled = ObjectSerializeManager.Object is null ? false : !ObjectSerializeManager.Object.IsSaved;
        }
        private void OptionsClosed() {
            //Reiniciando paineis
            //if (LayoutManager.GetPanelByType<CommentsPanel>() is CommentsPanel layersPanel)
            //Reiniciando layout
            //LayoutManager.UpdateLayout();
        }
        #endregion
        #region Layout Manager
        private void LayoutManager_SetStyle(ToolStripExtender style) {
            //style.SetStyle(MenuStrip);
            BackColor = DockPanel.Theme.ColorPalette.CommandBarMenuDefault.Background;
        }
        #endregion

        private void NewProject() {
            Hide();

            using (var startedPage = new StartedPage(LayoutManager, ObjectSerializeManager)) {
                startedPage.SetColors(LayoutManager.GetTheme().DockContentColorPalette);
                if (startedPage.ShowDialog() == DialogResult.OK) {
                    ///Abri o relatório de avaliação de um aplicativo.
                    ContentPanel.Controls.Clear();
                    reportPanel = new ReportPanel {
                        Dock = DockStyle.Fill
                    };
                    ContentPanel.Controls.Add(reportPanel);

                    ObjectSerializeManager.SaveObject();
                    currentSecion = $"{ObjectSerializeManager.Object.Name} {DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss")}";

                    Show();
                    //StartPosition = FormStartPosition.CenterScreen;
                    WindowState = FormWindowState.Normal;
                    WindowState = FormWindowState.Maximized;
                } else {
                    Close();
                }
            }
        }

        private ReportPanel reportPanel;




        private static string currentSecion;
        public static void SetLog(string log) {
            if (ObjectSerializeManager.Object.IsManual) {
                var fileInfo = new FileInfo(ObjectSerializeManager.Object.Directory);
                var dir = $@"{fileInfo.DirectoryName}\Logs";

                Directory.CreateDirectory(dir);

                var path = $@"{dir}\{currentSecion}.txt";
                var stream = File.AppendText(path);
                stream.WriteLine($"{log} : {DateTime.Now.ToLongTimeString()}");
                stream.Close();
            }
        }

        private void MasterPage_FormClosing(object sender, FormClosingEventArgs e) {
            //Salvando tempo de uso do cronograma.
            ObjectSerializeManager.Object.Stopwatch = reportPanel.Stopwatch;
            ObjectSerializeManager.SaveObject();
        }
    }
}