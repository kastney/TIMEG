namespace Smad.Pages {
    partial class MainPage {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripLayouts = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileRecentOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileSaveCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStripFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripWindowApps = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripWindowApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripWindowApplicationsComments = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripWindowFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripWindowProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripWindowWordCloud = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.DockPanel = new LiveShowStudio.Modules.DockPanelSuite.Docking.DockPanel();
            this.ToolStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLayouts});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(698, 25);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // ToolStripLayouts
            // 
            this.ToolStripLayouts.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripLayouts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripLayouts.Enabled = false;
            this.ToolStripLayouts.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripLayouts.Image")));
            this.ToolStripLayouts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripLayouts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripLayouts.Name = "ToolStripLayouts";
            this.ToolStripLayouts.Size = new System.Drawing.Size(34, 20);
            this.ToolStripLayouts.ToolTipText = "Layouts";
            this.ToolStripLayouts.Visible = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFile,
            this.MenuStripEdit,
            this.MenuStripWindow});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(698, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuStripFile
            // 
            this.MenuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFileNew,
            this.MenuStripFileOpen,
            this.MenuStripFileRecentOpen,
            this.MenuStripFileSeparator1,
            this.MenuStripFileClose,
            this.MenuStripFileSeparator2,
            this.MenuStripFileSave,
            this.MenuStripFileSaveAs,
            this.MenuStripFileSaveCopy,
            this.MenuStripFileSeparator3,
            this.MenuStripFileExit});
            this.MenuStripFile.Enabled = false;
            this.MenuStripFile.Name = "MenuStripFile";
            this.MenuStripFile.Size = new System.Drawing.Size(91, 29);
            this.MenuStripFile.Text = "Arquivo";
            this.MenuStripFile.Visible = false;
            // 
            // MenuStripFileNew
            // 
            this.MenuStripFileNew.Name = "MenuStripFileNew";
            this.MenuStripFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuStripFileNew.Size = new System.Drawing.Size(321, 34);
            this.MenuStripFileNew.Text = "Novo";
            this.MenuStripFileNew.Click += new System.EventHandler(this.MenuStripFileNew_Click);
            // 
            // MenuStripFileOpen
            // 
            this.MenuStripFileOpen.Name = "MenuStripFileOpen";
            this.MenuStripFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuStripFileOpen.Size = new System.Drawing.Size(321, 34);
            this.MenuStripFileOpen.Text = "Abrir";
            this.MenuStripFileOpen.Click += new System.EventHandler(this.MenuStripFileOpen_Click);
            // 
            // MenuStripFileRecentOpen
            // 
            this.MenuStripFileRecentOpen.Name = "MenuStripFileRecentOpen";
            this.MenuStripFileRecentOpen.Size = new System.Drawing.Size(321, 34);
            this.MenuStripFileRecentOpen.Text = "Abrir recentes";
            // 
            // MenuStripFileSeparator1
            // 
            this.MenuStripFileSeparator1.Name = "MenuStripFileSeparator1";
            this.MenuStripFileSeparator1.Size = new System.Drawing.Size(318, 6);
            // 
            // MenuStripFileClose
            // 
            this.MenuStripFileClose.Enabled = false;
            this.MenuStripFileClose.Name = "MenuStripFileClose";
            this.MenuStripFileClose.Size = new System.Drawing.Size(321, 34);
            this.MenuStripFileClose.Text = "Fechar";
            this.MenuStripFileClose.Click += new System.EventHandler(this.MenuStripFileClose_Click);
            // 
            // MenuStripFileSeparator2
            // 
            this.MenuStripFileSeparator2.Name = "MenuStripFileSeparator2";
            this.MenuStripFileSeparator2.Size = new System.Drawing.Size(318, 6);
            // 
            // MenuStripFileSave
            // 
            this.MenuStripFileSave.Enabled = false;
            this.MenuStripFileSave.Name = "MenuStripFileSave";
            this.MenuStripFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuStripFileSave.Size = new System.Drawing.Size(321, 34);
            this.MenuStripFileSave.Text = "Salvar";
            this.MenuStripFileSave.Click += new System.EventHandler(this.MenuStripFileSave_Click);
            // 
            // MenuStripFileSaveAs
            // 
            this.MenuStripFileSaveAs.Enabled = false;
            this.MenuStripFileSaveAs.Name = "MenuStripFileSaveAs";
            this.MenuStripFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuStripFileSaveAs.Size = new System.Drawing.Size(321, 34);
            this.MenuStripFileSaveAs.Text = "Salvar como";
            this.MenuStripFileSaveAs.Click += new System.EventHandler(this.MenuStripFileSaveAs_Click);
            // 
            // MenuStripFileSaveCopy
            // 
            this.MenuStripFileSaveCopy.Enabled = false;
            this.MenuStripFileSaveCopy.Name = "MenuStripFileSaveCopy";
            this.MenuStripFileSaveCopy.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.MenuStripFileSaveCopy.Size = new System.Drawing.Size(321, 34);
            this.MenuStripFileSaveCopy.Text = "Salvar cópia";
            this.MenuStripFileSaveCopy.Click += new System.EventHandler(this.MenuStripFileSaveCopy_Click);
            // 
            // MenuStripFileSeparator3
            // 
            this.MenuStripFileSeparator3.Name = "MenuStripFileSeparator3";
            this.MenuStripFileSeparator3.Size = new System.Drawing.Size(318, 6);
            // 
            // MenuStripFileExit
            // 
            this.MenuStripFileExit.Name = "MenuStripFileExit";
            this.MenuStripFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuStripFileExit.Size = new System.Drawing.Size(321, 34);
            this.MenuStripFileExit.Text = "Sair";
            this.MenuStripFileExit.Click += new System.EventHandler(this.MenuStripFileExit_Click);
            // 
            // MenuStripEdit
            // 
            this.MenuStripEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripWindowApps});
            this.MenuStripEdit.Enabled = false;
            this.MenuStripEdit.Name = "MenuStripEdit";
            this.MenuStripEdit.Size = new System.Drawing.Size(73, 29);
            this.MenuStripEdit.Text = "Editar";
            this.MenuStripEdit.Visible = false;
            // 
            // MenuStripWindowApps
            // 
            this.MenuStripWindowApps.Name = "MenuStripWindowApps";
            this.MenuStripWindowApps.Size = new System.Drawing.Size(228, 34);
            this.MenuStripWindowApps.Text = "Configurações";
            this.MenuStripWindowApps.Click += new System.EventHandler(this.MenuStripEditSettings_Click);
            // 
            // MenuStripWindow
            // 
            this.MenuStripWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripWindowApplications,
            this.MenuStripWindowApplicationsComments,
            this.MenuStripWindowFilters,
            this.MenuStripWindowProperties,
            this.MenuStripWindowWordCloud});
            this.MenuStripWindow.Enabled = false;
            this.MenuStripWindow.Name = "MenuStripWindow";
            this.MenuStripWindow.Size = new System.Drawing.Size(75, 29);
            this.MenuStripWindow.Text = "Janela";
            this.MenuStripWindow.Visible = false;
            // 
            // MenuStripWindowApplications
            // 
            this.MenuStripWindowApplications.Name = "MenuStripWindowApplications";
            this.MenuStripWindowApplications.Size = new System.Drawing.Size(266, 34);
            this.MenuStripWindowApplications.Text = "Aplicativos";
            this.MenuStripWindowApplications.Click += new System.EventHandler(this.MenuStripWindowApplications_Click);
            // 
            // MenuStripWindowApplicationsComments
            // 
            this.MenuStripWindowApplicationsComments.Name = "MenuStripWindowApplicationsComments";
            this.MenuStripWindowApplicationsComments.Size = new System.Drawing.Size(266, 34);
            this.MenuStripWindowApplicationsComments.Text = "Comentários";
            this.MenuStripWindowApplicationsComments.Click += new System.EventHandler(this.MenuStripWindowApplicationsComments_Click);
            // 
            // MenuStripWindowFilters
            // 
            this.MenuStripWindowFilters.Name = "MenuStripWindowFilters";
            this.MenuStripWindowFilters.Size = new System.Drawing.Size(266, 34);
            this.MenuStripWindowFilters.Text = "Filtros";
            this.MenuStripWindowFilters.Click += new System.EventHandler(this.MenuStripWindowFilters_Click);
            // 
            // MenuStripWindowProperties
            // 
            this.MenuStripWindowProperties.Name = "MenuStripWindowProperties";
            this.MenuStripWindowProperties.Size = new System.Drawing.Size(266, 34);
            this.MenuStripWindowProperties.Text = "Propriedades";
            this.MenuStripWindowProperties.Click += new System.EventHandler(this.MenuStripWindowProperties_Click);
            // 
            // MenuStripWindowWordCloud
            // 
            this.MenuStripWindowWordCloud.Name = "MenuStripWindowWordCloud";
            this.MenuStripWindowWordCloud.Size = new System.Drawing.Size(266, 34);
            this.MenuStripWindowWordCloud.Text = "Nuvem de palavras";
            this.MenuStripWindowWordCloud.Click += new System.EventHandler(this.MenuStripWindowWordCloud_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Location = new System.Drawing.Point(0, 402);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(698, 22);
            this.StatusStrip.TabIndex = 3;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // DockPanel
            // 
            this.DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockPanel.Location = new System.Drawing.Point(0, 49);
            this.DockPanel.Name = "DockPanel";
            this.DockPanel.Size = new System.Drawing.Size(698, 353);
            this.DockPanel.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 424);
            this.Controls.Add(this.DockPanel);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.StatusStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
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
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripLayouts;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileNew;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileRecentOpen;
        private System.Windows.Forms.ToolStripSeparator MenuStripFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileClose;
        private System.Windows.Forms.ToolStripSeparator MenuStripFileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileSave;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileSaveCopy;
        private System.Windows.Forms.ToolStripSeparator MenuStripFileSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFileExit;
        private System.Windows.Forms.ToolStripMenuItem MenuStripEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuStripWindowApps;
        private System.Windows.Forms.ToolStripMenuItem MenuStripWindow;
        private System.Windows.Forms.ToolStripMenuItem MenuStripWindowApplications;
        private System.Windows.Forms.ToolStripMenuItem MenuStripWindowApplicationsComments;
        private System.Windows.Forms.ToolStripMenuItem MenuStripWindowProperties;
        private System.Windows.Forms.ToolStripMenuItem MenuStripWindowFilters;
        private System.Windows.Forms.ToolStripMenuItem MenuStripWindowWordCloud;
    }
}