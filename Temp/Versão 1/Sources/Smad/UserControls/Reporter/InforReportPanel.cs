using System.Linq;
using System.Windows.Forms;

namespace Smad.UserControls.Reporter {

    public partial class InforReportPanel : UserControl, IReportPanel {

        public InforReportPanel() {
            InitializeComponent();
        }

        public void SetColors() {
            var palette = Pages.MasterPage.LayoutManager.GetTheme().DockContentColorPalette;
            BackColor = palette.Background;

            NameAppLabel.ForeColor = palette.TextColor;

            label1.ForeColor = palette.TextColor;
            label3.ForeColor = palette.TextColor;
            label4.ForeColor = palette.TextColor;
            label5.ForeColor = palette.TextColor;
            label6.ForeColor = palette.TextColor;

            RatingLabel.ForeColor = palette.TextColor;
            ComentsCount.ForeColor = palette.TextColor;
        }

        public void UpdateContent() {
            var experiment = Pages.MasterPage.ObjectSerializeManager.Object;

            IconImage.Image = experiment.Apps[0].Icon;
            NameAppLabel.Text = experiment.Apps[0].Name;
            RatingLabel.Text = experiment.Apps[0].StarRating.ToString();

            if (experiment.Apps[0].CommentsCout == 0) {
                experiment.Apps[0].CommentsCout = experiment.Apps[0].Comments.Count;
                experiment.Apps[0].Star1 = experiment.Apps[0].Comments.Where(a => a.Rating == 1).Count();
                experiment.Apps[0].Star2 = experiment.Apps[0].Comments.Where(a => a.Rating == 2).Count();
                experiment.Apps[0].Star3 = experiment.Apps[0].Comments.Where(a => a.Rating == 3).Count();
                experiment.Apps[0].Star4 = experiment.Apps[0].Comments.Where(a => a.Rating == 4).Count();
                experiment.Apps[0].Star5 = experiment.Apps[0].Comments.Where(a => a.Rating == 5).Count();
                Pages.MasterPage.ObjectSerializeManager.SaveObject();
            }

            ComentsCount.Text = $"Comentários: {experiment.Apps[0].CommentsCout}";
            ProgressBar1.Value = (experiment.Apps[0].Star1 * 100) / experiment.Apps[0].CommentsCout;
            ProgressBar2.Value = (experiment.Apps[0].Star2 * 100) / experiment.Apps[0].CommentsCout;
            ProgressBar3.Value = (experiment.Apps[0].Star3 * 100) / experiment.Apps[0].CommentsCout;
            ProgressBar4.Value = (experiment.Apps[0].Star4 * 100) / experiment.Apps[0].CommentsCout;
            ProgressBar5.Value = (experiment.Apps[0].Star5 * 100) / experiment.Apps[0].CommentsCout;

        }
    }
}