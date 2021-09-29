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

namespace Smad.Pages.Panels.Automatic {

    public partial class WordCloudPanel : UserControl {

        public WordCloudPanel() {
            InitializeComponent();

            var palette = MasterPage.LayoutManager.GetTheme().DockContentColorPalette;
            WordCloud.BackColor = palette.Control;
        }

        private void WordCloudPanel_Load(object sender, System.EventArgs e) {
            ProcessText();
        }

        private void ProcessText() {
            ProgressBar.Visible = true;

            IBlacklist blacklist = ComponentFactory.CreateBlacklist(true);
            IBlacklist customBlacklist = CommonBlacklist.CreateFromTextFile("blacklist.txt");

            IProgressIndicator progress = ComponentFactory.CreateProgressBar(InputType.String, ProgressBar);
            IEnumerable<string> terms = ComponentFactory.CreateExtractor(MasterPage.ObjectSerializeManager.Object.Apps[0].Comments, progress);
            IWordStemmer stemmer = ComponentFactory.CreateWordStemmer(true);

            IEnumerable<IWord> words = terms
                .Filter(blacklist)
                .Filter(customBlacklist)
                .CountOccurences();

            WordCloud.WeightedWords = words.GroupByStem(stemmer).SortByOccurences().Cast<IWord>();

            ProgressBar.Visible = false;
        }

        private void CloudControlClick(object sender, System.EventArgs e) {
            LayoutItem itemUderMouse;
            Point mousePositionRelativeToControl = WordCloud.PointToClient(new Point(MousePosition.X, MousePosition.Y));
            if (!WordCloud.TryGetItemAtLocation(mousePositionRelativeToControl, out itemUderMouse)) {
                return;
            }

            MessageBox.Show(
                itemUderMouse.Word.GetCaption(),
                string.Format("Estatisticas de palavras: [{0}]", itemUderMouse.Word.Text));
        }
    }
}