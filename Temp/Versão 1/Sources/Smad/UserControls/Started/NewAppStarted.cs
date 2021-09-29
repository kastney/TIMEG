using LiveShowStudio.Modules.DockPanelSuite.Docking;
using Smad.Dialogs;
using Smad.Entities;
using Smad.Helpers.Scrapers;
using System.Windows.Forms;

namespace Smad.UserControls.Started {

    public partial class NewAppStarted : BaseStarted {

        private DockContentColorPalette colorPalette;

        public NewAppStarted() {
            InitializeComponent();
        }

        public override void SetColors(DockContentColorPalette colorPalette) {
            this.colorPalette = colorPalette;

            TitleLabel.ForeColor = colorPalette.TextColor;

            CreateButton.BackColor = colorPalette.Control;
            CreateButton.ForeColor = colorPalette.TextColor;

            BackButton.BackColor = colorPalette.Control;
            BackButton.ForeColor = colorPalette.TextColor;

            DirectoryButton.BackColor = colorPalette.Control;
            DirectoryButton.ForeColor = colorPalette.TextColor;

            label1.ForeColor = colorPalette.TextColor;
            label2.ForeColor = colorPalette.TextColor;
            label3.ForeColor = colorPalette.TextColor;
            label4.ForeColor = colorPalette.TextColor;

            AppStoreComboBox.BackColor = colorPalette.Control;
            AppStoreComboBox.ForeColor = colorPalette.TextColor;

            AppCategoryComboBox.BackColor = colorPalette.Control;
            AppCategoryComboBox.ForeColor = colorPalette.TextColor;

            AppIdText.BackColor = colorPalette.Control;
            AppIdText.ForeColor = colorPalette.TextColor;

            DirectoryText.BackColor = colorPalette.Control;
            DirectoryText.ForeColor = colorPalette.TextColor;
        }

        private void BackButton_Click(object sender, System.EventArgs e) {
            BackHandler?.Invoke();
        }

        private void CreateButton_Click(object sender, System.EventArgs e) {
            ///Verificar se o aplicativo existe.
            //Foi informado o identificador do aplicativo.
            if (string.IsNullOrEmpty(AppIdText.Text)) {
                MessageBox.Show("Informe o identificador do aplicativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AppIdText.Focus();
                return;
            }
            //Verifica se existe o aplicativo.
            var app = GooglePlayScraper.BasicInfor(AppIdText.Text);
            if (app is null) {
                MessageBox.Show("Não foi possível obter o aplicativo como o identificador informado. Por favor, verifique se o identificador do aplicativo está correto e se possui conexão com a internet.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ///Verifica se o diretório existe
            //Foi informado o diretório.
            if (string.IsNullOrEmpty(DirectoryText.Text)) {
                MessageBox.Show("Informe o diretório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DirectoryButton.Focus();
                return;
            }

            //Verificar se diretório existe.
            var directoryInfo = new System.IO.DirectoryInfo(DirectoryText.Text);
            if (!directoryInfo.Parent.Exists) {
                MessageBox.Show("Esse diretório não é válido, informe novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InstantiateHandler?.Invoke(new Experiment {
                Apps = { app },
                Directory = DirectoryText.Text,
                IsSaved = false,
                Name = app.Name,
                Icon = app.GetIcon()
            });
        }

        private void NewAppStarted_Load(object sender, System.EventArgs e) {
            AppStoreComboBox.SelectedIndex = 0;
            AppCategoryComboBox.SelectedIndex = 0;
        }

        private void DirectoryButton_Click(object sender, System.EventArgs e) {
            using (var dialog = new SaveFileDialog()) {
                dialog.Filter = "Arquivo do Smad|*.smad";
                if (dialog.ShowDialog() == DialogResult.OK) {
                    DirectoryText.Text = dialog.FileName;
                }
            }
        }

        private void OnTextChanged(object sender, System.EventArgs e) {
            if (!string.IsNullOrEmpty(AppIdText.Text) && !string.IsNullOrEmpty(DirectoryText.Text)) {
                CreateButton.Enabled = true;
                CreateButton.BackColor = System.Drawing.SystemColors.Highlight;
            } else {
                CreateButton.Enabled = false;
                CreateButton.BackColor = colorPalette.Control;
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
            using(var page = new IdAppDialog()) {
                page.ShowDialog();
            }
        }
    }
}