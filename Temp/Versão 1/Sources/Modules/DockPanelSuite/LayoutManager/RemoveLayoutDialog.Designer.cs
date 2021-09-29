namespace LiveShowStudio.Modules.DockPanelSuite.LayoutManager {
    partial class RemoveLayoutDialog {
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
            this.LabelUserLayout = new System.Windows.Forms.Label();
            this.UserLayoutOptions = new System.Windows.Forms.ComboBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelUserLayout
            // 
            this.LabelUserLayout.AutoSize = true;
            this.LabelUserLayout.Location = new System.Drawing.Point(17, 33);
            this.LabelUserLayout.Name = "LabelUserLayout";
            this.LabelUserLayout.Size = new System.Drawing.Size(151, 20);
            this.LabelUserLayout.TabIndex = 0;
            this.LabelUserLayout.Text = "Selecione um layout";
            // 
            // UserLayoutOptions
            // 
            this.UserLayoutOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UserLayoutOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserLayoutOptions.FormattingEnabled = true;
            this.UserLayoutOptions.Location = new System.Drawing.Point(21, 56);
            this.UserLayoutOptions.Name = "UserLayoutOptions";
            this.UserLayoutOptions.Size = new System.Drawing.Size(384, 28);
            this.UserLayoutOptions.TabIndex = 1;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(291, 15);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(114, 35);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Apagar";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.SystemColors.Control;
            this.FooterPanel.Controls.Add(this.RemoveButton);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 119);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(428, 65);
            this.FooterPanel.TabIndex = 3;
            // 
            // RemoveLayoutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(428, 184);
            this.Controls.Add(this.LabelUserLayout);
            this.Controls.Add(this.UserLayoutOptions);
            this.Controls.Add(this.FooterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveLayoutDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apagar layout";
            this.FooterPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUserLayout;
        private System.Windows.Forms.ComboBox UserLayoutOptions;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Panel FooterPanel;
    }
}