using LiveShowStudio.Modules.DockPanelSuite.Docking;
using LiveShowStudio.Modules.ObjectListView;
using Smad.Entities;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Smad.Panels {

    public partial class CommentsPanel : DockContent {

        private BrowserPreviewPanel browserPreviewPanel;

        public CommentsPanel() => InitializeComponent();

        private void CommentsPanel_Load(object sender, System.EventArgs e) {
            var textOverlay = ListView.EmptyListMsgOverlay as TextOverlay;
            textOverlay.Font = new Font("Microsoft Sans Serif", 8);
            textOverlay.BorderWidth = 0;
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
        }

        public override void UpdateContent() {
            //Define o modo de exibição do painel de comentários.
            if (Pages.MainPage.ObjectSerializeManager is null || Pages.MainPage.ObjectSerializeManager.Object is null || Pages.MainPage.Index == -1) {
                Off();
            } else {
                On();
            }
        }
        private void On() {
            ToolStripInit.Enabled = true;
            ToolStripPlus.Enabled = true;

            if (Pages.MainPage.Index < Pages.MainPage.ObjectSerializeManager.Object.Apps.Count) {
                ListView.Objects = Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].ProcessComments;
                ListView.SelectedIndex = -1;
                Text = $"Comentários [{Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Name}]";

                ToolStripInit.Enabled = Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].ProcessComments.Count == 0 ? true : false;
            }
        }
        private void Off() {
            ToolStripInit.Enabled = false;
            ToolStripPlus.Enabled = false;

            Text = "Comentários";
            ListView.Objects = null;
        }

        private void ToolStripInit_Click(object sender, System.EventArgs e) {
            browserPreviewPanel = Pages.MainPage.LayoutManager.OpenDialog<BrowserPreviewPanel>();
            browserPreviewPanel.FinishHandler = FinishHandler;
            browserPreviewPanel.GetComments(Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Id);
            browserPreviewPanel.ShowDialog();
        }
        private void FinishHandler(List<Comment> comments) {
            browserPreviewPanel.Close();
            browserPreviewPanel = null;

            //Preencer comentários
            Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Comments = comments;
            Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Filters.Add(new StatisticalSample());
            foreach (var comment in comments) {
                Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].ProcessComments.Add(comment);
            }
            //Informações dos comentários
            Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].CommentsCout = comments.Count;
            Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Star1 = comments.Where(a => a.Rating == 1).Count();
            Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Star2 = comments.Where(a => a.Rating == 2).Count();
            Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Star3 = comments.Where(a => a.Rating == 3).Count();
            Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Star4 = comments.Where(a => a.Rating == 4).Count();
            Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Star5 = comments.Where(a => a.Rating == 5).Count();
            //Registra nova mudança.
            Pages.MainPage.ObjectSerializeManager.RegisterChanged();

            UpdatePanels();
        }

        private void UpdatePanels() {
            On();

            if (Pages.MainPage.LayoutManager.GetPanelByType<PropertiesPanel>() is PropertiesPanel propertiesPanel) {
                propertiesPanel.UpdateContent();
                propertiesPanel.PropertyGrid.Refresh();
            }

            if (Pages.MainPage.LayoutManager.GetPanelByType<FilterPanel>() is FilterPanel filterPanel) {
                filterPanel.UpdateContent();
            }

            if (Pages.MainPage.LayoutManager.GetPanelByType<WordCloudPanel>() is WordCloudPanel wordCloudPanel) {
                wordCloudPanel.UpdateContent();
            }
        }









        private void ToolStripPlusExportCSV_Click(object sender, System.EventArgs e) {
            try {
                var dir = $"./{Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Id}.csv";
                var valor = new StreamWriter(dir, true, Encoding.UTF8);
                valor.WriteLine("UserName\tMessage\tRating\tLike\tPublishDate");
                for (int i = 0; i < Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Comments.Count; i++) {
                    //anexa dados com separador
                    var comment = Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].ProcessComments[i];
                    valor.WriteLine($"{comment.UserName}\t{comment.Message}\t{comment.Rating}\t{comment.Like}\t{comment.PublishDate}");
                }
                valor.Close();
            } catch (System.Exception ex) { }
        }
    }
}