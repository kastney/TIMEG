namespace Smad.UserControls {
    partial class CardView {
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
            this.CardPanel = new System.Windows.Forms.Panel();
            this.IconImage = new System.Windows.Forms.PictureBox();
            this.TitleText = new System.Windows.Forms.Label();
            this.CardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardPanel.Controls.Add(this.IconImage);
            this.CardPanel.Controls.Add(this.TitleText);
            this.CardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardPanel.Location = new System.Drawing.Point(20, 20);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.CardPanel.Size = new System.Drawing.Size(260, 260);
            this.CardPanel.TabIndex = 0;
            // 
            // IconImage
            // 
            this.IconImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconImage.Location = new System.Drawing.Point(10, 15);
            this.IconImage.Name = "IconImage";
            this.IconImage.Size = new System.Drawing.Size(238, 115);
            this.IconImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconImage.TabIndex = 0;
            this.IconImage.TabStop = false;
            this.IconImage.Click += new System.EventHandler(this.OnClick);
            this.IconImage.DoubleClick += new System.EventHandler(this.OnDoubleClick);
            // 
            // TitleText
            // 
            this.TitleText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.ForeColor = System.Drawing.SystemColors.Window;
            this.TitleText.Location = new System.Drawing.Point(10, 130);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(238, 118);
            this.TitleText.TabIndex = 1;
            this.TitleText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TitleText.Click += new System.EventHandler(this.OnClick);
            this.TitleText.DoubleClick += new System.EventHandler(this.OnDoubleClick);
            // 
            // CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CardPanel);
            this.Name = "CardView";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.CardView_Load);
            this.CardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox IconImage;
        public System.Windows.Forms.Label TitleText;
        public System.Windows.Forms.Panel CardPanel;
    }
}
