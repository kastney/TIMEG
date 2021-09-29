using LiveShowStudio.Modules.DockPanelSuite.Docking;
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

namespace Smad.Panels {

    public partial class WordCloudPanel : DockContent {

        public WordCloudPanel() => InitializeComponent();

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
            WordCloud.BackColor = colorPalette.Background;
        }
        public override void SetStyle(ToolStripExtender style) {
            style.SetStyle(ToolStrip);
        }

        public override void UpdateContent() {
            //Define o modo de exibição do painel de comentários.
            //if (Pages.MasterPage.ObjectSerializeManager is null || Pages.MasterPage.ObjectSerializeManager.Object is null || Pages.MasterPage.Index == -1) {
                //Off();
            //} else {
                //if (Pages.MasterPage.ObjectSerializeManager.Object.Apps[Pages.MasterPage.Index].ProcessComments.Count != 0) {
                //On();
                //}
            //}
        }
        private void On() {
            //if (Pages.MasterPage.Index < Pages.MasterPage.ObjectSerializeManager.Object.Apps.Count) {
            //WordCloud.Enabled = true;
            //WordCloud.Visible = true;
            //ProcessText();
            //}
        }
        private void Off() {
            WordCloud.Enabled = false;
            WordCloud.Visible = false;
            ToolStripProgressBar.Visible = false;
        }

        private void ProcessText() {
            //ToolStripProgressBar.Visible = true;

            //IBlacklist blacklist = ComponentFactory.CreateBlacklist(true);
            //IBlacklist customBlacklist = CommonBlacklist.CreateFromTextFile("blacklist.txt");

            //IProgressIndicator progress = ComponentFactory.CreateProgressBar(InputType.String, ToolStripProgressBar);
            //IEnumerable<string> terms = ComponentFactory.CreateExtractor(Pages.MasterPage.ObjectSerializeManager.Object.Apps[Pages.MasterPage.Index].ProcessComments, progress);
            //IWordStemmer stemmer = ComponentFactory.CreateWordStemmer(true);

            //IEnumerable<IWord> words = terms
            //    .Filter(blacklist)
            //    .Filter(customBlacklist)
            //    .CountOccurences();

            //WordCloud.WeightedWords = words.GroupByStem(stemmer).SortByOccurences().Cast<IWord>();

            //ToolStripProgressBar.Visible = false;
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