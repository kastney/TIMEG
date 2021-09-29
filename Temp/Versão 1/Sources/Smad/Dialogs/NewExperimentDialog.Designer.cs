namespace Smad.Dialogs {
    partial class NewExperimentDialog {
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.PropertiesPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameLiveLabel = new System.Windows.Forms.Label();
            this.NameLiveText = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PropertiesPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Location = new System.Drawing.Point(206, 617);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(115, 35);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Criar";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // PropertiesPanel
            // 
            this.PropertiesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PropertiesPanel.Controls.Add(this.flowLayoutPanel1);
            this.PropertiesPanel.Controls.Add(this.CancelButton);
            this.PropertiesPanel.Controls.Add(this.CreateButton);
            this.PropertiesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PropertiesPanel.Location = new System.Drawing.Point(708, 0);
            this.PropertiesPanel.Name = "PropertiesPanel";
            this.PropertiesPanel.Padding = new System.Windows.Forms.Padding(10);
            this.PropertiesPanel.Size = new System.Drawing.Size(350, 664);
            this.PropertiesPanel.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 559);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NameLiveLabel);
            this.panel1.Controls.Add(this.NameLiveText);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 128);
            this.panel1.TabIndex = 2;
            // 
            // NameLiveLabel
            // 
            this.NameLiveLabel.AutoSize = true;
            this.NameLiveLabel.Location = new System.Drawing.Point(-3, 0);
            this.NameLiveLabel.Name = "NameLiveLabel";
            this.NameLiveLabel.Size = new System.Drawing.Size(108, 20);
            this.NameLiveLabel.TabIndex = 1;
            this.NameLiveLabel.Text = " Nome projeto";
            // 
            // NameLiveText
            // 
            this.NameLiveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLiveText.Location = new System.Drawing.Point(0, 23);
            this.NameLiveText.Name = "NameLiveText";
            this.NameLiveText.Size = new System.Drawing.Size(290, 35);
            this.NameLiveText.TabIndex = 0;
            this.NameLiveText.Text = "Sem título";
            this.NameLiveText.Leave += new System.EventHandler(this.NameLiveText_Leave);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(85, 617);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 35);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NewLiveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.PropertiesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewLiveDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo projeto";
            this.PropertiesPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Panel PropertiesPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox NameLiveText;
        private System.Windows.Forms.Label NameLiveLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}