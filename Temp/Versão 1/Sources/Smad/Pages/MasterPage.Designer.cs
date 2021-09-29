namespace Smad.Pages {
    partial class MasterPage {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterPage));
            this.DockPanel = new LiveShowStudio.Modules.DockPanelSuite.Docking.DockPanel();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripLayouts = new System.Windows.Forms.ToolStripDropDownButton();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileRecentOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DockPanel
            // 
            this.DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockPanel.Location = new System.Drawing.Point(0, 0);
            this.DockPanel.Name = "DockPanel";
            this.DockPanel.Size = new System.Drawing.Size(1058, 664);
            this.DockPanel.TabIndex = 0;
            // 
            // ToolStrip
            // 
            this.ToolStrip.Enabled = false;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLayouts});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1058, 33);
            this.ToolStrip.TabIndex = 2;
            this.ToolStrip.Text = "toolStrip1";
            this.ToolStrip.Visible = false;
            // 
            // ToolStripLayouts
            // 
            this.ToolStripLayouts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripLayouts.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripLayouts.Image")));
            this.ToolStripLayouts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripLayouts.Name = "ToolStripLayouts";
            this.ToolStripLayouts.Size = new System.Drawing.Size(42, 28);
            this.ToolStripLayouts.Text = "toolStripDropDownButton1";
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1058, 664);
            this.ContentPanel.TabIndex = 3;
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFile});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1058, 36);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            this.MenuStrip.Visible = false;
            // 
            // MenuStripFile
            // 
            this.MenuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFileRecentOpen});
            this.MenuStripFile.Name = "MenuStripFile";
            this.MenuStripFile.Size = new System.Drawing.Size(91, 32);
            this.MenuStripFile.Text = "Arquivo";
            // 
            // MenuStripFileRecentOpen
            // 
            this.MenuStripFileRecentOpen.Name = "MenuStripFileRecentOpen";
            this.MenuStripFileRecentOpen.Size = new System.Drawing.Size(223, 34);
            this.MenuStripFileRecentOpen.Text = "Abrir recentes";
            // 
            // MasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.DockPanel);
            this.Controls.Add(this.ToolStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "MasterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smad [salvamento automático]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterPage_FormClosing);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveShowStudio.Modules.DockPanelSuite.Docking.DockPanel DockPanel;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripLayouts;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileRecentOpen;
    }
}