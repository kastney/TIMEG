namespace LiveShowStudio.Modules.DockPanelSuite.LayoutManager {
    partial class NewLayoutDialog {
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
            this.LabelLayoutName = new System.Windows.Forms.Label();
            this.TextLayoutName = new System.Windows.Forms.TextBox();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(291, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(114, 35);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Salvar";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LabelLayoutName
            // 
            this.LabelLayoutName.AutoSize = true;
            this.LabelLayoutName.Location = new System.Drawing.Point(17, 33);
            this.LabelLayoutName.Name = "LabelLayoutName";
            this.LabelLayoutName.Size = new System.Drawing.Size(119, 20);
            this.LabelLayoutName.TabIndex = 2;
            this.LabelLayoutName.Text = "Nome do layout";
            // 
            // TextLayoutName
            // 
            this.TextLayoutName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextLayoutName.Location = new System.Drawing.Point(21, 56);
            this.TextLayoutName.Name = "TextLayoutName";
            this.TextLayoutName.Size = new System.Drawing.Size(384, 26);
            this.TextLayoutName.TabIndex = 0;
            this.TextLayoutName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextLayoutName_KeyDown);
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.SystemColors.Control;
            this.FooterPanel.Controls.Add(this.AddButton);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 119);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(428, 65);
            this.FooterPanel.TabIndex = 3;
            // 
            // NewLayoutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(428, 184);
            this.Controls.Add(this.LabelLayoutName);
            this.Controls.Add(this.TextLayoutName);
            this.Controls.Add(this.FooterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewLayoutDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salvar novo layout";
            this.FooterPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label LabelLayoutName;
        private System.Windows.Forms.TextBox TextLayoutName;
        private System.Windows.Forms.Panel FooterPanel;
    }
}