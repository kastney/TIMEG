using LiveShowStudio.Modules.DockPanelSuite.Docking;
using Smad.Entities;
using Smad.Helpers.Scrapers;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Smad.Panels {

    public delegate void FinishHandler(List<Comment> comments);

    public partial class BrowserPreviewPanel : DockContent {

        private const int SITE_HIT_MAX = 10;

        private readonly List<Comment> comments;

        private int heightPage;
        private int siteHit;
        private bool isFinish = false;

        public FinishHandler FinishHandler { get; set; }

        public BrowserPreviewPanel() {
            InitializeComponent();
            comments = new List<Comment>();
            ((Control)WebBrowser).Enabled = false;
        }
        private void BrowserPreviewPanel_FormClosing(object sender, FormClosingEventArgs e) {
            if (isFinish == false && MessageBox.Show("Você quer parar o processo de download de comentários?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                e.Cancel = true;
            }
        }

        public override void SetColors(DockContentColorPalette colorPalette) {

        }

        public override void SetStyle(ToolStripExtender style) {
            style.SetStyle(ToolStrip);
        }

        public void GetComments(string id) {
            //var additionalHeaders = "User-Agent:Mozilla/5.0 (Windows Phone 10.0; Android 6.0.1; " +
            //    "Microsoft; Lumia 950 XL Dual SIM) AppleWebKit/537.36 (KHTML, like Gecko) " +
            //    "Chrome/52.0.2743.116 Mobile Safari/537.36 Edge/15.15063\r\n";
            WebBrowser.Navigate($"https://play.google.com/store/apps/details?id={id}&showAllReviews=true"/*, null, null, additionalHeaders*/);
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            comments.Clear();
            Timer.Start();
        }

        private void Timer_Tick(object sender, System.EventArgs e) {
            //Executa após um tempo.
            if (WebBrowser.IsDisposed == false && WebBrowser.Document != null && WebBrowser.Document.Body != null) {
                //Scrola a página para baixo.
                WebBrowser.Document.Window.ScrollTo(0, WebBrowser.Document.Body.ScrollRectangle.Height);

                //Verifica se a página ficou parada.
                var heightPage = WebBrowser.Document.Body.ScrollRectangle.Height;
                if (this.heightPage == heightPage) {
                    siteHit++;

                    //Obtém o click "Mostrar mais".
                    foreach (HtmlElement element in WebBrowser.Document.GetElementsByTagName("div")) {
                        if (element.GetAttribute("role").Equals("button") && element.GetAttribute("jsname").Equals("i3y3Ic")) {
                            element.InvokeMember("Click");
                            siteHit = 0;
                            break;
                        }
                    }

                    //Após constatar que a página não se move mais.
                    if (siteHit == SITE_HIT_MAX) {
                        ExtractComments();
                    }
                }
                this.heightPage = heightPage;
            }
        }

        private void ToolStripCancel_Click(object sender, System.EventArgs e) {
            if (MessageBox.Show("Você quer parar o processo de download dos comentários", "Finalizar processo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                ExtractComments();
            }
        }

        private void ExtractComments() {
            //Aperta todos os comentários com botão "Ler mais".
            foreach (HtmlElement element in WebBrowser.Document.GetElementsByTagName("button")) {
                if (element.GetAttribute("jsname").Equals("gxjVle")) {
                    element.InvokeMember("Click");
                }
            }

            //Obtém todos os comentário baixados
            foreach (HtmlElement element in WebBrowser.Document.GetElementsByTagName("div")) {
                if (element.GetAttribute("jsname").Equals("fk8dgd")) {

                    //Percorre cada comentário baixado
                    foreach (HtmlElement commentElement in element.Children) {
                        //Popular lista de comentários extraidos
                        comments.Add(GooglePlayScraper.CommentInfor(commentElement.OuterHtml));
                    }

                    break;
                }
            }

            Timer.Stop();
            WebBrowser.Navigate("");
            isFinish = true;
            FinishHandler?.Invoke(comments.ToList());
        }
    }
}