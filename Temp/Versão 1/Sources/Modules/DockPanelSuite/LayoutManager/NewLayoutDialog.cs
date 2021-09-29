using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LiveShowStudio.Modules.DockPanelSuite.LayoutManager {

    public partial class NewLayoutDialog : Form {

        public string LayoutName { get; private set; }
        private const string BADCHARS = "\\/:*?\"<>|";
        private readonly List<Layout> defaultLayouts;
        private readonly List<string> userLayouts;

        public NewLayoutDialog(List<string> userLayouts, List<Layout> defaultLayouts) {
            InitializeComponent();
            this.userLayouts = userLayouts;
            this.defaultLayouts = defaultLayouts;
        }

        private void SetName() {
            var value = TextLayoutName.Text.Trim();
            if (IsValidFileName(value)) {
                LayoutName = value;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private bool IsValidFileName(string name) {
            if (string.IsNullOrEmpty(name)) return false;

            if (userLayouts.Contains(name) || defaultLayouts.FirstOrDefault(a => a.Name.Equals(name)) != null) {
                MessageBox.Show("O nome informado já existe! Por favor, tente novamente com outro nome", "Nome repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (var badChar in BADCHARS) {
                if (name.IndexOf(badChar) != -1) {
                    MessageBox.Show($"O nome informado possui um ou mais caracteres inválidos! Por favor, evite usar {BADCHARS}", "Nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void AddButton_Click(object sender, System.EventArgs e) => SetName();
        private void TextLayoutName_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) SetName();
        }
    }
}
