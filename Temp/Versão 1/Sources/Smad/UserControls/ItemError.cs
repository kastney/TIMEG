using Smad.Pages;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Smad.UserControls {

    public partial class ItemError : UserControl {

        public EventHandler UpdateData { get; set; }

        private Entities.Item item;
        public Entities.Item Item {
            get { return item; }
            private set { item = value; }
        }

        public ItemError(Entities.Item item) {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Item = item;
        }
        private void ItemError_Load(object sender, System.EventArgs e) {
            //Imagem.
            if (item.Print != null) {
                var converter = new ImageConverter();
                pictureBox1.Image = (Image)converter.ConvertFrom(item.Print);

                RemoveButton.Visible = true;
                pictureBox1.BackgroundImage = null;
            } else {
                RemoveButton.Visible = false;
                pictureBox1.BackgroundImage = Properties.Resources.add_print;
            }

            //Descrição.
            ProblemRichTextBox.Text = item.Problem;

            //Localização.
            LocationRichTextBox.Text = item.Location;

            //Severidade.
            SeverityLevelComboBox.SelectedIndex = item.SeverityLevel;
        }


        ///Descrição do problema.
        string currentProblem = "";
        private void ProblemRichTextBox_Leave(object sender, System.EventArgs e) {
            if (!currentProblem.Equals(ProblemRichTextBox.Text)) {
                currentProblem = ProblemRichTextBox.Text;
                Save();
                MasterPage.SetLog($"Descrição do problema - {item.Group} {item.Code} - '{ProblemRichTextBox.Text.Replace('\n', ' ')}'");
            }
        }

        ///Localização do problema.
        string currentLocation = "";
        private void LocationRichTextBox_Leave(object sender, EventArgs e) {
            if (!currentLocation.Equals(LocationRichTextBox.Text)) {
                currentLocation = LocationRichTextBox.Text;
                Save();
                MasterPage.SetLog($"Descrição da localização - {item.Group} {item.Code} - '{LocationRichTextBox.Text.Replace('\n', ' ')}'");
            }
        }

        ///Severidade do problema.
        private void SeverityLevelComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            Save();
            MasterPage.SetLog($"Severidade do problema - {SeverityLevelComboBox.SelectedItem}'");
        }

        ///Print do problema.
        private void pictureBox1_Click(object sender, EventArgs e) {
            using (var dialog = new OpenFileDialog()) {
                dialog.Filter = "Imagem JPG|*.jpg|Imagem PNG|*.png";
                if (dialog.ShowDialog() == DialogResult.OK) {
                    pictureBox1.Image = Image.FromFile(dialog.FileName);
                    RemoveButton.Visible = true;
                    pictureBox1.BackgroundImage = null;

                    Save();
                    MasterPage.SetLog($"Adicionando print - {item.Group} {item.Code}");
                }
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e) {
            pictureBox1.Image = null;
            RemoveButton.Visible = false;
            pictureBox1.BackgroundImage = Properties.Resources.add_print;

            Save();
            MasterPage.SetLog($"Removido print - {item.Group} {item.Code}");
        }





        private void Save() {
            ///Atualizar arquivo.
            var index = MasterPage.ObjectSerializeManager.Object.Items.IndexOf(item);
            if (pictureBox1.Image != null) {
                var ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                MasterPage.ObjectSerializeManager.Object.Items[index].Print = ms.ToArray();
            } else {
                MasterPage.ObjectSerializeManager.Object.Items[index].Print = null;
            }

            MasterPage.ObjectSerializeManager.Object.Items[index].Problem = ProblemRichTextBox.Text;
            MasterPage.ObjectSerializeManager.Object.Items[index].Location = LocationRichTextBox.Text;
            MasterPage.ObjectSerializeManager.Object.Items[index].SeverityLevel = SeverityLevelComboBox.SelectedIndex;
            MasterPage.ObjectSerializeManager.SaveObject();
            UpdateData?.Invoke(null, null);
        }

        private void SeverityLevelLabel_Click(object sender, EventArgs e) {

        }
    }
}