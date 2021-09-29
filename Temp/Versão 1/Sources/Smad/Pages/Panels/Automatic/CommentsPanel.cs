using LiveShowStudio.Modules.ObjectListView;
using Smad.Entities;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;

namespace Smad.Pages.Panels.Automatic {

    public partial class CommentsPanel : UserControl {

        public CommentsPanel() {
            InitializeComponent();

            var palette = MasterPage.LayoutManager.GetTheme().DockContentColorPalette;
            ListView.BackColor = palette.Control;
            ListView.ForeColor = palette.TextColor;
        }

        private void CommentsPanel_Load(object sender, EventArgs e) {
            ListView.Objects = GetComments();
            ListView.CellToolTipShowing += new EventHandler<ToolTipShowingEventArgs>(olv_CellToolTipShowing);
        }

        private IEnumerable<Comment> GetComments(string term = "") {
            //Realça o texto digitado nas linhas que o contém.
            ListView.ModelFilter = TextMatchFilter.Contains(ListView, SearchText.Text);
            ListView.ChangeToFilteredColumns(View.Details);

            var comments = MasterPage.ObjectSerializeManager.Object.Apps[0].Comments;
            if (string.IsNullOrEmpty(term)) {
                return comments;
            } else {
                var result = comments.Where(a =>
                a.Message.ToLower().Contains(term.ToLower()) ||
                a.UserName.ToLower().Contains(term.ToLower()) ||
                a.PublishDate.ToLower().Contains(term.ToLower()) ||
                a.Like.ToString().Contains(term) ||
                a.Rating.ToString().Contains(term));
                return result;
            }
        }

        private void SearchText_TextChanged(object sender, EventArgs e) {
            ListView.Objects = GetComments(SearchText.Text);
        }

        private void ExportCSV_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && int.TryParse(ContextMenuStripExportCSV.Text, out int sampleSize)) {
                var dir = $"{MasterPage.ObjectSerializeManager.Object.Directory}.csv";//
                GenerateAmount(MasterPage.ObjectSerializeManager.Object.Apps[0], sampleSize, dir);
            }
        }

        private void GenerateAmount(App app, int sampleSize, string dir) {
            int[] sizes = new int[5];
            float[] pos = new float[5];

            for (int i = 0; i < 5; i++) {
                var b = (float)app.Comments.Where(a => a.Rating.Equals(i + 1)).Count() * 100 / app.Comments.Count / 100;
                float posAux = sampleSize * b;
                sizes[i] = (int)posAux;
                pos[i] = posAux - sizes[i];
            }

            var diference = sampleSize - sizes.Sum();
            for (int i = 0; i < diference; i++) {
                var max = pos.Max();
                for (int j = 0; j < pos.Length; j++) {
                    if (max == pos[j]) {
                        sizes[j]++;
                        pos[j] = 0;
                        j = pos.Length;
                    }
                }
            }

            //Separa a amostra
            app.ProcessComments = new List<Comment>();
            foreach (var comment in app.Comments) {
                if (sizes[comment.Rating - 1] != 0) {
                    sizes[comment.Rating - 1]--;
                    app.ProcessComments.Add(comment);
                }
                if (sizes[0] == 0 && sizes[1] == 0 && sizes[2] == 0 && sizes[3] == 0 && sizes[4] == 0) {
                    break;
                }
            }

            //Exportar em um arquivo .csv
            try {
                var valor = new StreamWriter(dir, true, Encoding.UTF8);
                valor.WriteLine("UserName\tMessage\tRating\tLike\tPublishDate");
                for (int i = 0; i < app.ProcessComments.Count; i++) {
                    //anexa dados com separador
                    var comment = app.ProcessComments[i];
                    valor.WriteLine($"{comment.UserName}\t{comment.Message}\t{comment.Rating}\t{comment.Like}\t{comment.PublishDate}");
                }
                valor.Close();
            } catch (Exception ex) { }
        }

        void olv_CellToolTipShowing(object sender, ToolTipShowingEventArgs e) {
            var comment = e.Model as Comment;
            e.Text = comment.Message;
            e.Title = comment.UserName;
            e.Font = new Font("Tahoma", 10);
        }
    }
}