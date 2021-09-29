
namespace Smad.UserControls {
    partial class ItemError {
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
            this.RemoveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SeverityLevelComboBox = new System.Windows.Forms.ComboBox();
            this.SeverityLevelLabel = new System.Windows.Forms.Label();
            this.LocationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.ProblemRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ProblemLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(1222, 92);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(87, 30);
            this.RemoveButton.TabIndex = 20;
            this.RemoveButton.Text = "Remover";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(909, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SeverityLevelComboBox
            // 
            this.SeverityLevelComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.SeverityLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeverityLevelComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SeverityLevelComboBox.FormattingEnabled = true;
            this.SeverityLevelComboBox.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.SeverityLevelComboBox.Location = new System.Drawing.Point(1130, 128);
            this.SeverityLevelComboBox.Name = "SeverityLevelComboBox";
            this.SeverityLevelComboBox.Size = new System.Drawing.Size(179, 28);
            this.SeverityLevelComboBox.TabIndex = 17;
            this.SeverityLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.SeverityLevelComboBox_SelectedIndexChanged);
            // 
            // SeverityLevelLabel
            // 
            this.SeverityLevelLabel.AutoSize = true;
            this.SeverityLevelLabel.Location = new System.Drawing.Point(905, 133);
            this.SeverityLevelLabel.Name = "SeverityLevelLabel";
            this.SeverityLevelLabel.Size = new System.Drawing.Size(219, 20);
            this.SeverityLevelLabel.TabIndex = 18;
            this.SeverityLevelLabel.Text = "Nível de severidade/prioridade";
            this.SeverityLevelLabel.Click += new System.EventHandler(this.SeverityLevelLabel_Click);
            // 
            // LocationRichTextBox
            // 
            this.LocationRichTextBox.Location = new System.Drawing.Point(467, 28);
            this.LocationRichTextBox.Name = "LocationRichTextBox";
            this.LocationRichTextBox.Size = new System.Drawing.Size(400, 128);
            this.LocationRichTextBox.TabIndex = 16;
            this.LocationRichTextBox.Text = "";
            this.LocationRichTextBox.Leave += new System.EventHandler(this.LocationRichTextBox_Leave);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(464, 7);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(185, 20);
            this.LocationLabel.TabIndex = 15;
            this.LocationLabel.Text = "Localização do problema";
            // 
            // ProblemRichTextBox
            // 
            this.ProblemRichTextBox.Location = new System.Drawing.Point(24, 29);
            this.ProblemRichTextBox.Name = "ProblemRichTextBox";
            this.ProblemRichTextBox.Size = new System.Drawing.Size(400, 127);
            this.ProblemRichTextBox.TabIndex = 14;
            this.ProblemRichTextBox.Text = "";
            this.ProblemRichTextBox.Leave += new System.EventHandler(this.ProblemRichTextBox_Leave);
            // 
            // ProblemLabel
            // 
            this.ProblemLabel.AutoSize = true;
            this.ProblemLabel.Location = new System.Drawing.Point(20, 7);
            this.ProblemLabel.Name = "ProblemLabel";
            this.ProblemLabel.Size = new System.Drawing.Size(172, 20);
            this.ProblemLabel.TabIndex = 13;
            this.ProblemLabel.Text = "Descrição do problema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 21;
            // 
            // ItemError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SeverityLevelLabel);
            this.Controls.Add(this.SeverityLevelComboBox);
            this.Controls.Add(this.LocationRichTextBox);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.ProblemRichTextBox);
            this.Controls.Add(this.ProblemLabel);
            this.Name = "ItemError";
            this.Size = new System.Drawing.Size(1347, 184);
            this.Load += new System.EventHandler(this.ItemError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox SeverityLevelComboBox;
        private System.Windows.Forms.Label SeverityLevelLabel;
        private System.Windows.Forms.RichTextBox LocationRichTextBox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.RichTextBox ProblemRichTextBox;
        private System.Windows.Forms.Label ProblemLabel;
        private System.Windows.Forms.Label label1;
    }
}
