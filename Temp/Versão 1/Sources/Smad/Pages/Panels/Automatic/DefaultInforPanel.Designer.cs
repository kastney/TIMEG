namespace Smad.Pages.Panels.Automatic {
    partial class DefaultInforPanel {
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
            this.IconImage = new System.Windows.Forms.PictureBox();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.EvaluationCountLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.IconImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconImage
            // 
            this.IconImage.Location = new System.Drawing.Point(53, 53);
            this.IconImage.Name = "IconImage";
            this.IconImage.Size = new System.Drawing.Size(200, 200);
            this.IconImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconImage.TabIndex = 0;
            this.IconImage.TabStop = false;
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNameLabel.Location = new System.Drawing.Point(259, 53);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(539, 137);
            this.AppNameLabel.TabIndex = 1;
            this.AppNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RatingLabel
            // 
            this.RatingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingLabel.Location = new System.Drawing.Point(3, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(173, 60);
            this.RatingLabel.TabIndex = 2;
            this.RatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EvaluationCountLabel
            // 
            this.EvaluationCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluationCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluationCountLabel.Location = new System.Drawing.Point(182, 0);
            this.EvaluationCountLabel.Name = "EvaluationCountLabel";
            this.EvaluationCountLabel.Size = new System.Drawing.Size(173, 60);
            this.EvaluationCountLabel.TabIndex = 3;
            this.EvaluationCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CategoryLabel.Location = new System.Drawing.Point(361, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(175, 60);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.CategoryLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EvaluationCountLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RatingLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(259, 193);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 60);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // DefaultInforPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AppNameLabel);
            this.Controls.Add(this.IconImage);
            this.Name = "DefaultInforPanel";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Size = new System.Drawing.Size(851, 310);
            this.Load += new System.EventHandler(this.DefaultInforPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox IconImage;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label EvaluationCountLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
