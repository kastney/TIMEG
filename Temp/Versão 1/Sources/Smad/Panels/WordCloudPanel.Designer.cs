namespace Smad.Panels {
    partial class WordCloudPanel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            this.WordCloud.Location = new System.Drawing.Point(0, 38);
            this.WordCloud.MaxFontSize = 30;
            this.WordCloud.MinFontSize = 10;
            this.WordCloud.Name = "WordCloud";
            this.WordCloud.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.LightSkyBlue,
        System.Drawing.Color.Lime,
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.DarkOrange,
        System.Drawing.Color.DarkGoldenrod,
        System.Drawing.Color.DarkKhaki,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
        System.Drawing.Color.Green};
            this.WordCloud.Size = new System.Drawing.Size(800, 412);
            this.WordCloud.TabIndex = 1;
            this.WordCloud.WeightedWords = null;
            this.WordCloud.Click += new System.EventHandler(this.CloudControlClick);
            // 
            // ToolStrip
            // 
            this.ToolStrip.AutoSize = false;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripProgressBar});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(0, 10, 2, 10);
            this.ToolStrip.Size = new System.Drawing.Size(800, 38);
            this.ToolStrip.TabIndex = 0;
            // 
            // ToolStripProgressBar
            // 
            this.ToolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripProgressBar.Name = "ToolStripProgressBar";
            this.ToolStripProgressBar.Size = new System.Drawing.Size(100, 13);
            // 
            // WordCloudPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WordCloud);
            this.Controls.Add(this.ToolStrip);
            this.Name = "WordCloudPanel";
            this.ShowHint = LiveShowStudio.Modules.DockPanelSuite.Docking.DockState.Document;
            this.Text = "Nuvem de palavras";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Nulo.WinForms.Control.WordCloudGenerator.WordCloud WordCloud;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar;
    }
}