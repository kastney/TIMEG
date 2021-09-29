namespace Smad.Pages.Panels.Automatic {
    partial class WordCloudPanel {
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
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.WordCloud = new Nulo.WinForms.Control.WordCloudGenerator.WordCloud();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar.Location = new System.Drawing.Point(50, 427);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(700, 23);
            this.ProgressBar.TabIndex = 1;
            this.ProgressBar.Visible = false;
            // 
            // WordCloud
            // 
            this.WordCloud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WordCloud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WordCloud.LayoutType = Nulo.WinForms.Control.WordCloudGenerator.LayoutType.Spiral;
            this.WordCloud.Location = new System.Drawing.Point(53, 53);
            this.WordCloud.MaxFontSize = 40;
            this.WordCloud.MinFontSize = 7;
            this.WordCloud.Name = "WordCloud";
            this.WordCloud.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.RoyalBlue,
        System.Drawing.Color.SeaGreen,
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.DarkSlateGray,
        System.Drawing.Color.CadetBlue,
        System.Drawing.Color.DarkGoldenrod,
        System.Drawing.Color.Purple,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.DarkGreen};
            this.WordCloud.Size = new System.Drawing.Size(694, 394);
            this.WordCloud.TabIndex = 0;
            this.WordCloud.WeightedWords = null;
            this.WordCloud.Click += new System.EventHandler(this.CloudControlClick);
            // 
            // WordCloudPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.WordCloud);
            this.Name = "WordCloudPanel";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.WordCloudPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Nulo.WinForms.Control.WordCloudGenerator.WordCloud WordCloud;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}
