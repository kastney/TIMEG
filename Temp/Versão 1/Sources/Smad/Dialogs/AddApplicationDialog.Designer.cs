namespace Smad.Dialogs {
    partial class AddApplicationDialog {
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
            this.AddButton = new System.Windows.Forms.Button();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdText = new System.Windows.Forms.TextBox();
            this.InforPanel = new System.Windows.Forms.GroupBox();
            this.NameText = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.IconImage = new System.Windows.Forms.PictureBox();
            this.FooterPanel.SuspendLayout();
            this.InforPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconImage)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(352, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(114, 35);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Adicionar";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.SystemColors.Control;
            this.FooterPanel.Controls.Add(this.CancelButton);
            this.FooterPanel.Controls.Add(this.AddButton);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 253);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(478, 65);
            this.FooterPanel.TabIndex = 5;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(232, 15);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(114, 35);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id do aplicativo";
            // 
            // IdText
            // 
            this.IdText.Location = new System.Drawing.Point(12, 33);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(334, 26);
            this.IdText.TabIndex = 1;
            // 
            // InforPanel
            // 
            this.InforPanel.Controls.Add(this.IconImage);
            this.InforPanel.Controls.Add(this.NameText);
            this.InforPanel.Location = new System.Drawing.Point(12, 98);
            this.InforPanel.Name = "InforPanel";
            this.InforPanel.Size = new System.Drawing.Size(454, 133);
            this.InforPanel.TabIndex = 6;
            this.InforPanel.TabStop = false;
            this.InforPanel.Text = "Informações sobre o aplicativo";
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(120, 25);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(328, 102);
            this.NameText.TabIndex = 1;
            this.NameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchButton
            // 
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(352, 31);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(114, 35);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Buscar";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // IconImage
            // 
            this.IconImage.Location = new System.Drawing.Point(6, 25);
            this.IconImage.Name = "IconImage";
            this.IconImage.Size = new System.Drawing.Size(108, 102);
            this.IconImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconImage.TabIndex = 2;
            this.IconImage.TabStop = false;
            // 
            // AddApplicationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(478, 318);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.InforPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.FooterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddApplicationDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar aplicativo";
            this.FooterPanel.ResumeLayout(false);
            this.InforPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.GroupBox InforPanel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.PictureBox IconImage;
    }
}