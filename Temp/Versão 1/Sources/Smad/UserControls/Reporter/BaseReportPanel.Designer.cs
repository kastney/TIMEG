namespace Smad.UserControls.Reporter {
    partial class BaseReportPanel {
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
            this.InforReportPanel = new Smad.UserControls.Reporter.InforReportPanel();
            this.WordCloudReportPanel = new Smad.UserControls.Reporter.WordCloudReportPanel();
            this.SuspendLayout();
            // 
            // InforReportPanel
            // 
            this.InforReportPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InforReportPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InforReportPanel.Location = new System.Drawing.Point(0, 0);
            this.InforReportPanel.Name = "InforReportPanel";
            this.InforReportPanel.Padding = new System.Windows.Forms.Padding(20);
            this.InforReportPanel.Size = new System.Drawing.Size(866, 550);
            this.InforReportPanel.TabIndex = 0;
            // 
            // WordCloudReportPanel
            // 
            this.WordCloudReportPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WordCloudReportPanel.Location = new System.Drawing.Point(0, 550);
            this.WordCloudReportPanel.Name = "WordCloudReportPanel";
            this.WordCloudReportPanel.Size = new System.Drawing.Size(866, 740);
            this.WordCloudReportPanel.TabIndex = 1;
            // 
            // BaseReportPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WordCloudReportPanel);
            this.Controls.Add(this.InforReportPanel);
            this.Name = "BaseReportPanel";
            this.Size = new System.Drawing.Size(866, 1410);
            this.ResumeLayout(false);

        }

        #endregion

        public InforReportPanel InforReportPanel;
        public WordCloudReportPanel WordCloudReportPanel;
    }
}
