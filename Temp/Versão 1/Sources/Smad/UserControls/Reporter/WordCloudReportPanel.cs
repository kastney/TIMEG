using Nulo.WinForms.Control.WordCloudGenerator.Geometry;
using Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Blacklist;
using Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Extractors;
using Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Processing;
using Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Stemmers;
using Smad.Helpers.WordCloud;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Smad.UserControls.Reporter {

    public partial class WordCloudReportPanel : UserControl, IReportPanel {

        public WordCloudReportPanel() => InitializeComponent();

        public void SetColors() {
            var palette = Pages.MasterPage.LayoutManager.GetTheme().DockContentColorPalette;

            BackColor = palette.Background;
            WordCloud.BackColor = palette.Background;
        }

        public void UpdateContent() {
            ProcessText();
        }

        private void ProcessText() {
            ToolStrip.Visible = true;

            IBlacklist blacklist = ComponentFactory.CreateBlacklist(true);
            IBlacklist customBlacklist = CommonBlacklist.CreateFromTextFile("blacklist.txt");

            IProgressIndicator progress = ComponentFactory.CreateProgressBar(InputType.String, ToolStripProgressBar);
            IEnumerable<string> terms = ComponentFactory.CreateExtractor(Pages.MasterPage.ObjectSerializeManager.Object.Apps[0].ProcessComments, progress);
            IWordStemmer stemmer = ComponentFactory.CreateWordStemmer(true);

            IEnumerable<IWord> words = terms
                .Filter(blacklist)
                .Filter(customBlacklist)
                .CountOccurences();

            WordCloud.WeightedWords = words.GroupByStem(stemmer).SortByOccurences().Cast<IWord>();

            ToolStrip.Visible = false;
        }

        private void CloudControlClick(object sender, System.EventArgs e) {
            LayoutItem itemUderMouse;
            Point mousePositionRelativeToControl = WordCloud.PointToClient(new Point(MousePosition.X, MousePosition.Y));
            if (!WordCloud.TryGetItemAtLocation(mousePositionRelativeToControl, out itemUderMouse)) {
                return;
            }

            MessageBox.Show(itemUderMouse.Word.GetCaption(), string.Format("Estatisticas de palavras: [{0}]", itemUderMouse.Word.Text));
        }
    }
}