using Smad.Entities;
using System.Drawing;
using Smad.Modules.ObjectSerialize;
using LiveShowStudio.Modules.ObjectListView;
using LiveShowStudio.Modules.DockPanelSuite.Docking;
using LiveShowStudio.Modules.ObjectSerializeManager;
using System.IO;
using System.Windows.Forms;

namespace Smad.UserControls.Started {

    public partial class RecentStarted : BaseStarted {

        private ObjectSerializeManager<Experiment, ObjectData> objectSerializeManager;

        public RecentStarted(ObjectSerializeManager<Experiment, ObjectData> objectSerializeManager) {
            InitializeComponent();
            this.objectSerializeManager = objectSerializeManager;
        }
        private void RecentStarted_Load(object sender, System.EventArgs e) {
            var textOverlay = ListView.EmptyListMsgOverlay as TextOverlay;
            textOverlay.Font = new Font("Microsoft Sans Serif", 10);
            textOverlay.BorderWidth = 0;

            ListViewMain.ImageGetter = delegate (object row) {
                var icon = ((RecentObject)row).Icon;
                if (icon != null) {
                    return new Bitmap(Image.FromStream(new MemoryStream(icon)), new Size(30, 30));
                } else {
                    return new Bitmap(Properties.Resources.app_icon, new Size(30, 30));
                }
            };
        }

        public override void SetColors(DockContentColorPalette colorPalette) {
            TitleLabel.ForeColor = colorPalette.TextColor;
            ListView.BackColor = colorPalette.Background;
            ListView.ForeColor = colorPalette.TextColor;
            DescribedTaskRenderer.DescriptionColor = colorPalette.TextColor;

            var textOverlay = ListView.EmptyListMsgOverlay as TextOverlay;
            textOverlay.BackColor = colorPalette.Background;
        }

        public override void UpdateContent() {
            ListView.Objects = objectSerializeManager.GetRecentObject();
        }

        Timer timer = new Timer { Interval = 10 };
        bool timeFlag = true;
        private void ListView_SelectedIndexChanged(object sender, System.EventArgs e) {
            if (ListView.SelectedIndex != -1 && timeFlag) {
                var recentObject = ListView.SelectedObject as RecentObject;

                ListView.SelectedIndex = -1;
                timer.Tick += Timer_Tick;
                timeFlag = false;

                if (!File.Exists(recentObject.Directory)) {
                    if (MessageBox.Show("Aparentemente esse arquivo não existe mais!\nVocê quer remover dos arquivos recentes?", "Remover dos arquivos recentes", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) {
                        objectSerializeManager.RemoveRecent(recentObject);
                        UpdateContent();
                    }

                    timer.Start();
                    return;
                }

                objectSerializeManager.CloseObject();
                objectSerializeManager.OpenObject(recentObject.Directory);

                if (objectSerializeManager.Object != null) {
                    InstantiateHandler?.Invoke(objectSerializeManager.Object);
                    timer.Start();
                }
            }
        }

        private void Timer_Tick(object sender, System.EventArgs e) {
            ListView.SelectedIndex = -1;
            timeFlag = true;
            timer.Stop();
        }

        private void OnRemoveRecentObject(object sender, CellClickEventArgs e) {
            if (MessageBox.Show("Remover esse projeto dos arquivos recentes?", "Remover dos arquivos recentes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                objectSerializeManager.RemoveRecent((RecentObject)e.Model);
                UpdateContent();
            }
        }
    }
}