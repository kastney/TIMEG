using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace Smad.Pages.Panels.Automatic {

    public partial class ChecklistPanel : UserControl {

        private Entities.Item currentItem;
        public EventHandler UpdateData { get; set; }

        public ChecklistPanel() {
            InitializeComponent();

            var palette = MasterPage.LayoutManager.GetTheme().DockContentColorPalette;
            ListView.BackColor = palette.Control;
            ListView.ForeColor = palette.TextColor;

            NameLabel.ForeColor = palette.TextColor;
            CodeLabel.ForeColor = palette.TextColor;
            CategoryLabel.ForeColor = palette.TextColor;

            InspectorLabel.ForeColor = palette.TextColor;
            InspectorComboBox.BackColor = palette.Background;
            InspectorComboBox.ForeColor = palette.TextColor;

            ProblemLabel.ForeColor = palette.TextColor;
            ProblemRichTextBox.BackColor = palette.Background;
            ProblemRichTextBox.ForeColor = palette.TextColor;

            LocationLabel.ForeColor = palette.TextColor;
            LocationRichTextBox.BackColor = palette.Background;
            LocationRichTextBox.ForeColor = palette.TextColor;

            SeverityLevelLabel.ForeColor = palette.TextColor;
            SeverityLevelComboBox.BackColor = palette.Background;
            SeverityLevelComboBox.ForeColor = palette.TextColor;
        }

        private void ChecklistPanel_Load(object sender, System.EventArgs e) {
            ///Definindo os icones de status dos itens.
            olvColumn3.ImageGetter = delegate (object row) {
                switch (((Entities.Item)row).IsError) {
                    case 0: {
                        return new Bitmap(Properties.Resources.icon_ok, new Size(20, 20));
                    }
                    case 1: {
                        return new Bitmap(Properties.Resources.icon_error, new Size(20, 20));
                    }
                    default: {
                        return new Bitmap(Properties.Resources.icon_clear, new Size(20, 20));
                    }
                }
            };

            ///Definindo o grupo de itens.
            //Definindo os grupos disponíveis.
            string groupCurrent = "";
            foreach (var item in MasterPage.ObjectSerializeManager.Object.Items) {
                if (!item.Group.Equals(groupCurrent)) {
                    groupCurrent = item.Group;
                    GroupComboBox.Items.Add(item.Group);
                }
            }
            GroupComboBox.SelectedItem = MasterPage.ObjectSerializeManager.Object.Group;

            ///Definindo visubilidade inicial de componentes da interface.
            InspectorComboBox.Visible = false;
            InspectorLabel.Visible = false;

            ProblemLabel.Visible = false;
            ProblemRichTextBox.Visible = false;
            LocationLabel.Visible = false;
            LocationRichTextBox.Visible = false;
            SeverityLevelLabel.Visible = false;
            SeverityLevelComboBox.Visible = false;
            pictureBox1.Visible = false;
            RemoveButton.Visible = false;
        }
        private void ListView_SelectedIndexChanged(object sender, EventArgs e) {
            if (!(ListView.SelectedObject is Entities.Item item)) {
                ///Resetar o formulário.
                NameLabel.Text = "";
                CodeLabel.Text = "";
                CategoryLabel.Text = "";
                pictureBox1.Image = null;

                InspectorComboBox.Visible = false;
                InspectorLabel.Visible = false;

                ProblemLabel.Visible = false;
                ProblemRichTextBox.Visible = false;
                LocationLabel.Visible = false;
                LocationRichTextBox.Visible = false;
                SeverityLevelLabel.Visible = false;
                SeverityLevelComboBox.Visible = false;
                pictureBox1.Visible = false;
                RemoveButton.Visible = false;

                currentItem = ListView.SelectedObject as Entities.Item;
                return;
            }

            NameLabel.Text = item.Name;
            CodeLabel.Text = $"Código do item: {item.Code}";
            CategoryLabel.Text = $"Categoria do item: {item.Category}";
            if (item.Print != null) {
                var converter = new ImageConverter();
                pictureBox1.Image = (Image)converter.ConvertFrom(item.Print);
            }

            InspectorComboBox.SelectedIndex = item.IsError;
            InspectorComboBox.Visible = true;
            InspectorLabel.Visible = true;

            if (item.IsError == 1) {
                ProblemLabel.Visible = true;
                ProblemRichTextBox.Text = item.Problem;
                ProblemRichTextBox.Visible = true;

                LocationLabel.Visible = true;
                LocationRichTextBox.Text = item.Location;
                LocationRichTextBox.Visible = true;

                SeverityLevelLabel.Visible = true;
                SeverityLevelComboBox.SelectedIndex = item.SeverityLevel;
                SeverityLevelComboBox.Visible = true;

                pictureBox1.Visible = true;
                if (item.Print != null) {
                    RemoveButton.Visible = true;
                    pictureBox1.BackgroundImage = null;
                } else {
                    RemoveButton.Visible = false;
                    pictureBox1.BackgroundImage = Properties.Resources.add_print;
                }
            }

            currentItem = ListView.SelectedObject as Entities.Item;
        }
        private void InspectorComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (ListView.SelectedIndex != -1) {
                var index = MasterPage.ObjectSerializeManager.Object.Items.IndexOf(ListView.SelectedObject as Entities.Item);
                MasterPage.ObjectSerializeManager.Object.Items[index].IsError = InspectorComboBox.SelectedIndex;
                MasterPage.ObjectSerializeManager.SaveObject();

                if (InspectorComboBox.SelectedIndex == 1) {
                    ProblemLabel.Visible = true;
                    ProblemRichTextBox.Visible = true;
                    LocationLabel.Visible = true;
                    LocationRichTextBox.Visible = true;
                    SeverityLevelLabel.Visible = true;
                    SeverityLevelComboBox.Visible = true;
                    pictureBox1.Visible = true;
                    RemoveButton.Visible = true;
                } else {
                    ProblemLabel.Visible = false;
                    ProblemRichTextBox.Visible = false;
                    LocationLabel.Visible = false;
                    LocationRichTextBox.Visible = false;
                    SeverityLevelLabel.Visible = false;
                    SeverityLevelComboBox.Visible = false;
                    pictureBox1.Visible = false;
                    RemoveButton.Visible = false;
                }

                GroupComboBox_SelectedIndexChanged(null, null);
            }
        }

        string currentProblem = "";
        private void ProblemRichTextBox_Leave(object sender, EventArgs e) {
            if (!currentProblem.Equals(ProblemRichTextBox.Text)) {
                currentProblem = ProblemRichTextBox.Text;
                Save();
                MasterPage.SetLog($"Descrição do problema - {((Entities.Item)ListView.SelectedObject).Group} {((Entities.Item)ListView.SelectedObject).Code} - '{ProblemRichTextBox.Text.Replace('\n', ' ')}'");
            }
        }
        string currentLocation = "";
        private void LocationRichTextBox_Leave(object sender, EventArgs e) {
            if (!currentLocation.Equals(LocationRichTextBox.Text)) {
                currentLocation = LocationRichTextBox.Text;
                Save();
                MasterPage.SetLog($"Descrição da localização - {((Entities.Item)ListView.SelectedObject).Group} {((Entities.Item)ListView.SelectedObject).Code} - '{LocationRichTextBox.Text.Replace('\n', ' ')}'");
            }
        }

        private void SeverityLevelComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            Save();
            MasterPage.SetLog($"Severidade do problema - {SeverityLevelComboBox.SelectedItem}'");
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            using (var dialog = new OpenFileDialog()) {
                dialog.Filter = "Imagem JPG|*.jpg|Imagem PNG|*.png";
                if (dialog.ShowDialog() == DialogResult.OK) {
                    pictureBox1.Image = Image.FromFile(dialog.FileName);
                    RemoveButton.Visible = true;
                    Save();
                    MasterPage.SetLog($"Adicionando print - {((Entities.Item)ListView.SelectedObject).Group} {((Entities.Item)ListView.SelectedObject).Code}");
                }
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e) {
            pictureBox1.Image = null;
            RemoveButton.Visible = false;
            Save();
            MasterPage.SetLog($"Removido print - {((Entities.Item)ListView.SelectedObject).Group} {((Entities.Item)ListView.SelectedObject).Code}");
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.Objects = MasterPage.ObjectSerializeManager.Object.Items.Where(a => a.Group.Equals(GroupComboBox.SelectedItem));
            
            Save();
            MasterPage.ObjectSerializeManager.Object.Group = GroupComboBox.Text;
            MasterPage.ObjectSerializeManager.SaveObject();

            MasterPage.SetLog($"Seleção da técnica - {GroupComboBox.SelectedItem}");
        }

        private void Save() {
            ///Atualizar arquivo.
            if (currentItem != null) {
                var index = MasterPage.ObjectSerializeManager.Object.Items.IndexOf(currentItem);
                if (pictureBox1.Image != null) {
                    var ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    MasterPage.ObjectSerializeManager.Object.Items[index].Print = ms.ToArray();
                } else {
                    MasterPage.ObjectSerializeManager.Object.Items[index].Print = null;
                }
                MasterPage.ObjectSerializeManager.Object.Group = GroupComboBox.Text;
                MasterPage.ObjectSerializeManager.Object.Items[index].Problem = ProblemRichTextBox.Text;
                MasterPage.ObjectSerializeManager.Object.Items[index].Location = LocationRichTextBox.Text;
                MasterPage.ObjectSerializeManager.Object.Items[index].SeverityLevel = SeverityLevelComboBox.SelectedIndex;
                MasterPage.ObjectSerializeManager.SaveObject();
                UpdateData?.Invoke(null, null);
            }
        }
    }
}