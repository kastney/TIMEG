using Smad.Entities;
using Smad.Helpers.Scrapers;
using Smad.Panels;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Smad.Dialogs {

    public partial class IdApplicationDialog : Form {

        public List<Comment> Comments { get; set; }
        public App App { get; set; }

        BrowserPreviewPanel browserPreview;

        public IdApplicationDialog() {
            InitializeComponent();
        }

        private void AppIdText_Click(object sender, System.EventArgs e) {
            //Verifica se existe o aplicativo.
            var app = GooglePlayScraper.BasicInfor(AppIdText.Text);
            if (app is null) {
                MessageBox.Show("Não foi possível obter o aplicativo como o identificador informado. Por favor, verifique se o identificador do aplicativo está correto e se possui conexão com a internet.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            App = app;

            MessageBox.Show("Será necessário baixar os comentários desse aplicativo.\nEsse processo pode demorar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (browserPreview = new BrowserPreviewPanel()) {
                browserPreview.FinishHandler = Finish;
                browserPreview.GetComments(AppIdText.Text);
                browserPreview.ShowDialog();
            }
        }
        private void Finish(List<Comment> comments) {
            browserPreview.Close();
            Comments = comments;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnTextChanged(object sender, System.EventArgs e) {
            if (!string.IsNullOrEmpty(AppIdText.Text)) {
                CreateButton.Enabled = true;
            } else {
                CreateButton.Enabled = false;
            }
        }

        private void pictureBox1_MouseHover(object sender, System.EventArgs e) {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(pictureBox1, "Digiti o código do aplicativo encontrado na Google Play Store");
        }
        private void AppIdText_MouseHover(object sender, System.EventArgs e) {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(AppIdText, "Digiti o código do aplicativo encontrado na Google Play Store");
        }
        private void pictureBox1_Click(object sender, System.EventArgs e) {
            using (var page = new IdAppDialog()) {
                page.ShowDialog();
            }
        }
    }
}