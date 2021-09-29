
namespace Smad.Pages.Panels.Manual {
    partial class ChecklistPanel3 {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebBrowser
            // 
            this.WebBrowser.AllowNavigation = false;
            this.WebBrowser.AllowWebBrowserDrop = false;
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.WebBrowser.Location = new System.Drawing.Point(0, 0);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(915, 655);
            this.WebBrowser.TabIndex = 1;
            this.WebBrowser.TabStop = false;
            this.WebBrowser.WebBrowserShortcutsEnabled = false;
            this.WebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser_DocumentCompleted);
            // 
            // ChecklistPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WebBrowser);
            this.Name = "ChecklistPanel";
            this.Size = new System.Drawing.Size(915, 655);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebBrowser;
    }
}
