using Smad.Dialogs;
using Smad.Entities;
using System.Windows.Forms;
using LiveShowStudio.Modules.DockPanelSuite.Docking;
using Smad.Helpers.Scrapers;

namespace Smad.UserControls.Started {

    public partial class NewManualStarted : BaseStarted {

        private DockContentColorPalette colorPalette;

        public NewManualStarted() {
            InitializeComponent();
        }
        private void NewManualStarted_Load(object sender, System.EventArgs e) {
            AppStoreComboBox.SelectedIndex = 1;
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

            AppIdText.BackColor = colorPalette.Control;
            AppIdText.ForeColor = colorPalette.TextColor;

            DirectoryText.BackColor = colorPalette.Control;
            DirectoryText.ForeColor = colorPalette.TextColor;

            AppStoreComboBox.BackColor = colorPalette.Control;
            AppStoreComboBox.ForeColor = colorPalette.TextColor;

            textBox1.BackColor = colorPalette.Control;
            textBox1.ForeColor = colorPalette.TextColor;
        }

        private void BackButton_Click(object sender, System.EventArgs e) {
            BackHandler?.Invoke();
        }

        private void CreateButton_Click(object sender, System.EventArgs e) {
            ///Verifica se foi informado o nome do aplicativo.
            if (string.IsNullOrEmpty(AppIdText.Text)) {
                MessageBox.Show("Informe o nome do aplicativo/projeto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AppIdText.Focus();
                return;
            }

            ///Verifica se foi informado o diretório.
            if (string.IsNullOrEmpty(DirectoryText.Text)) {
                MessageBox.Show("Informe o diretório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DirectoryButton.Focus();
                return;
            }

            ///Verificar se diretório existe e é válido.
            var directoryInfo = new System.IO.DirectoryInfo(DirectoryText.Text);
            if (!directoryInfo.Parent.Exists) {
                MessageBox.Show("Esse diretório não é válido, informe novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(textBox1.Text)) {
                //Verifica se existe o aplicativo.
                var app = GooglePlayScraper.BasicInfor(textBox1.Text);
                if (app is null) {
                    MessageBox.Show("Não foi possível obter o aplicativo como o identificador informado. Por favor, verifique se o identificador do aplicativo está correto e se possui conexão com a internet.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                InstantiateHandler?.Invoke(new Experiment {
                    Apps = { app },
                    Directory = DirectoryText.Text,
                    IsSaved = false,
                    Name = AppIdText.Text,
                    IsManual = true,
                    Icon = app.GetIcon()
                });
            } else {
                InstantiateHandler?.Invoke(new Experiment {
                    Directory = DirectoryText.Text,
                    IsSaved = false,
                    Name = AppIdText.Text,
                    IsManual = true
                });
            }
        }

        private void DirectoryButton_Click(object sender, System.EventArgs e) {
            using (var dialog = new SaveFileDialog()) {
                dialog.Filter = "Arquivo do Smad|*.smad";
                dialog.FileName = AppIdText.Text;
                if (dialog.ShowDialog() == DialogResult.OK) {
                    DirectoryText.Text = dialog.FileName;
                }
            }
        }

        private void OnTextChanged(object sender, System.EventArgs e) {
            if (AppStoreComboBox.SelectedIndex == 1) {
                if (!string.IsNullOrEmpty(AppIdText.Text) && !string.IsNullOrEmpty(DirectoryText.Text)) {
                    CreateButton.Enabled = true;
                    CreateButton.BackColor = System.Drawing.SystemColors.Highlight;
                } else {
                    CreateButton.Enabled = false;
                    CreateButton.BackColor = colorPalette.Control;
                }
            } else {
                if (!string.IsNullOrEmpty(AppIdText.Text) && !string.IsNullOrEmpty(DirectoryText.Text) && !string.IsNullOrEmpty(textBox1.Text)) {
                    CreateButton.Enabled = true;
                    CreateButton.BackColor = System.Drawing.SystemColors.Highlight;
                } else {
                    CreateButton.Enabled = false;
                    CreateButton.BackColor = colorPalette.Control;
                }
            }
        }

        private void AppStoreComboBox_SelectedValueChanged(object sender, System.EventArgs e) {
            if (AppStoreComboBox.SelectedIndex == 0) {
                label2.Enabled = true;
                textBox1.Enabled = true;
                pictureBox1.Enabled = true;
            } else {
                label2.Enabled = false;
                textBox1.Enabled = false;
                pictureBox1.Enabled = false;
            }
            OnTextChanged(null, null);
        }

        private void textBox1_MouseHover(object sender, System.EventArgs e) {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(textBox1, "Digiti o código do aplicativo encontrado na Google Play Store");
        }
        private void pictureBox1_MouseHover(object sender, System.EventArgs e) {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(pictureBox1, "Digiti o código do aplicativo encontrado na Google Play Store");
        }
        private void pictureBox1_Click(object sender, System.EventArgs e) {
            using (var page = new IdAppDialog()) {
                page.ShowDialog();
            }
        }
    }
}