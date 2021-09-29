namespace Smad.UserControls.Reporter {
    partial class WordCloudReportPanel {
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
            this.WordCloud = new Nulo.WinForms.Control.WordCloudGenerator.WordCloud();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // WordCloud
            // 
            this.WordCloud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WordCloud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordCloud.LayoutType = Nulo.WinForms.Control.WordCloudGenerator.LayoutType.Spiral;
            this.WordCloud.Location = new System.Drawing.Point(0, 0);
            this.WordCloud.MaxFontSize = 68;
            this.WordCloud.MinFontSize = 6;
            this.WordCloud.Name = "WordCloud";
            this.WordCloud.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.DarkBlue,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.DarkOrange,
        System.Drawing.Color.DarkGoldenrod,
        System.Drawing.Color.DarkKhaki,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
        System.Drawing.Color.Green};
            this.WordCloud.Size = new System.Drawing.Size(830, 825);
            this.WordCloud.TabIndex = 0;
            this.WordCloud.WeightedWords = null;
            this.WordCloud.Click += new System.EventHandler(this.CloudControlClick);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripProgressBar});
            this.ToolStrip.Location = new System.Drawing.Point(0, 787);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(830, 38);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // ToolStripProgressBar
            // 
            this.ToolStripProgressBar.Name = "ToolStripProgressBar";
            this.ToolStripProgressBar.Size = new System.Drawing.Size(100, 33);
            // 
            // WordCloudReportPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.WordCloud);
            this.Name = "WordCloudReportPanel";
            this.Size = new System.Drawing.Size(830, 825);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Nulo.WinForms.Control.WordCloudGenerator.WordCloud WordCloud;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar;
    }
}
