using System.Drawing;
using System.Windows.Forms;

namespace Smad.UserControls {

    public partial class CardView : UserControl {

        private Color defaultBackColor;
        public event System.EventHandler SelectedChanged;
        public event System.EventHandler CardDoubleClick;

        public bool IsSelected { get; set; } = false;

        public CardView(int width = 250, int height = 250) {
            InitializeComponent();
            Width = width;
            Height = height;
        }
        private void CardView_Load(object sender, System.EventArgs e) => defaultBackColor = BackColor;

        private void OnClick(object sender, System.EventArgs e) {
            BackColor = SystemColors.Highlight;
            IsSelected = true;
            SelectedChanged?.Invoke(this, null);
        }
        private void OnDoubleClick(object sender, System.EventArgs e) {
            CardDoubleClick?.Invoke(this, null);
        }

        public void UnSelected() {
            BackColor = defaultBackColor;
            IsSelected = false;
        }
        public void Selected() {
            BackColor = SystemColors.Highlight;
            IsSelected = true;
        }
    }
}
