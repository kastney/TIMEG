namespace Smad.Panels {
    partial class ReportPanel {
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
            this.BaseReportPanel = new Smad.UserControls.Reporter.BaseReportPanel();
            this.SuspendLayout();
            // 
            // BaseReportPanel
            // 
            this.BaseReportPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BaseReportPanel.Location = new System.Drawing.Point(50, 50);
            this.BaseReportPanel.Name = "BaseReportPanel";
            this.BaseReportPanel.Size = new System.Drawing.Size(798, 1329);
            this.BaseReportPanel.TabIndex = 0;
            // 
            // ReportPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(924, 587);
            this.CloseButtonVisible = false;
            this.Controls.Add(this.BaseReportPanel);
            this.DockAreas = LiveShowStudio.Modules.DockPanelSuite.Docking.DockAreas.Document;
            this.Name = "ReportPanel";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.ShowHint = LiveShowStudio.Modules.DockPanelSuite.Docking.DockState.Document;
            this.Text = "ReportPanel";
            this.Load += new System.EventHandler(this.ReportPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Reporter.BaseReportPanel BaseReportPanel;
    }
}