using LiveShowStudio.Modules.DockPanelSuite.Docking;
using Smad.Entities;
using Smad.Helpers.Scrapers;
using System.Windows.Forms;
using System.Linq;

namespace Smad.Dialogs {

    public partial class AddApplicationDialog : DockContent {

        public App App { get; private set; }

        public AddApplicationDialog() {
            InitializeComponent();
        }

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Control;
            ForeColor = colorPalette.TextColor;
            FooterPanel.BackColor = colorPalette.Control;
            InforPanel.ForeColor = colorPalette.TextColor;

            IdText.BackColor = colorPalette.Background;
            IdText.ForeColor = colorPalette.TextColor;
        }

        private void SetInfor(App app) {
            NameText.Text = app.Name;
            IconImage.Image = app.Icon;
        }
        private void SetInfor() {
            NameText.Text = string.Empty;
            IconImage.Image = null;
        }

        private void SearchButton_Click(object sender, System.EventArgs e) {
            if (!string.IsNullOrEmpty(IdText.Text)) {
                //Verifica se o identificador já existe
                if (Pages.MainPage.ObjectSerializeManager.Object.Apps.FirstOrDefault(a => a.Id.Equals(IdText.Text)) != null) {
                    MessageBox.Show("Esse aplicativo já existe! Por favor, mude o identificador e tente novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    App = null;
                    SetInfor();
                    return;
                }

                //Obtém as informações da loja.
                App = GooglePlayScraper.BasicInfor(IdText.Text);
                if (App == null) {
                    MessageBox.Show("Erro ao obter dados do aplicativo! Verifique o identificador do aplicativo ou a conexão com a internet e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetInfor();
                    return;
                }

                //Define as informações na tela
                SetInfor(App);
            }
        }

        private void AddButton_Click(object sender, System.EventArgs e) {
            if (!string.IsNullOrEmpty(IdText.Text) && App != null) {
                //Encerra a janela de diálogo.
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}