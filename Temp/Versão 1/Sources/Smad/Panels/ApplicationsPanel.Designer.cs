namespace Smad.Panels {
    partial class ApplicationsPanel {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationsPanel));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripAddApp = new System.Windows.Forms.ToolStripButton();
            this.ListView = new LiveShowStudio.Modules.ObjectListView.FastObjectListView();
            this.ListViewName = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.AppContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AppContextMenuStripRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneralContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GeneralContextMenuStripAddApp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).BeginInit();
            this.AppContextMenuStrip.SuspendLayout();
            this.GeneralContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripAddApp});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(800, 25);
            this.ToolStrip.TabIndex = 0;
            // 
            // ToolStripAddApp
            // 
            this.ToolStripAddApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripAddApp.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripAddApp.Image")));
            this.ToolStripAddApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripAddApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripAddApp.Margin = new System.Windows.Forms.Padding(1, 2, 0, 3);
            this.ToolStripAddApp.Name = "ToolStripAddApp";
            this.ToolStripAddApp.Size = new System.Drawing.Size(34, 20);
            this.ToolStripAddApp.Text = "Adicionar aplicativo";
            this.ToolStripAddApp.Click += new System.EventHandler(this.AddApp_Click);
            // 
            // ListView
            // 
            this.ListView.AllColumns.Add(this.ListViewName);
            this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListViewName});
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.EmptyListMsg = "Nenhum aplicativo";
            this.ListView.FullRowSelect = true;
            this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(0, 25);
            this.ListView.MultiSelect = false;
            this.ListView.Name = "ListView";
            this.ListView.RowHeight = 55;
            this.ListView.SelectColumnsOnRightClick = false;
            this.ListView.SelectColumnsOnRightClickBehaviour = LiveShowStudio.Modules.ObjectListView.ObjectListView.ColumnSelectBehaviour.None;
            this.ListView.ShowGroups = false;
            this.ListView.Size = new System.Drawing.Size(800, 425);
            this.ListView.TabIndex = 1;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.VirtualMode = true;
            this.ListView.CellRightClick += new System.EventHandler<LiveShowStudio.Modules.ObjectListView.CellRightClickEventArgs>(this.ListView_CellRightClick);
            this.ListView.SelectionChanged += new System.EventHandler(this.ListView_SelectionChanged);
            this.ListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView_KeyDown);
            // 
            // ListViewName
            // 
            this.ListViewName.AspectName = "Name";
            this.ListViewName.FillsFreeSpace = true;
            this.ListViewName.IsEditable = false;
            this.ListViewName.Sortable = false;
            this.ListViewName.UseFiltering = false;
            // 
            // AppContextMenuStrip
            // 
            this.AppContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.AppContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppContextMenuStripRemove});
            this.AppContextMenuStrip.Name = "AppContextMenuStrip";
            this.AppContextMenuStrip.Size = new System.Drawing.Size(143, 36);
            // 
            // AppContextMenuStripRemove
            // 
            this.AppContextMenuStripRemove.Name = "AppContextMenuStripRemove";
            this.AppContextMenuStripRemove.Size = new System.Drawing.Size(142, 32);
            this.AppContextMenuStripRemove.Text = "Apagar";
            this.AppContextMenuStripRemove.Click += new System.EventHandler(this.RemoveApp_Click);
            // 
            // GeneralContextMenuStrip
            // 
            this.GeneralContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.GeneralContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GeneralContextMenuStripAddApp});
            this.GeneralContextMenuStrip.Name = "GeneralContextMenuStrip";
            this.GeneralContextMenuStrip.Size = new System.Drawing.Size(240, 36);
            // 
            // GeneralContextMenuStripAddApp
            // 
            this.GeneralContextMenuStripAddApp.Name = "GeneralContextMenuStripAddApp";
            this.GeneralContextMenuStripAddApp.Size = new System.Drawing.Size(239, 32);
            this.GeneralContextMenuStripAddApp.Text = "Adicionar aplicativo";
            this.GeneralContextMenuStripAddApp.Click += new System.EventHandler(this.AddApp_Click);
            // 
            // ApplicationsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.ToolStrip);
            this.Name = "ApplicationsPanel";
            this.ShowHint = LiveShowStudio.Modules.DockPanelSuite.Docking.DockState.DockLeft;
            this.Text = "Aplicativos";
            this.Load += new System.EventHandler(this.ApplicationsPanel_Load);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).EndInit();
            this.AppContextMenuStrip.ResumeLayout(false);
            this.GeneralContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private LiveShowStudio.Modules.ObjectListView.FastObjectListView ListView;
        private System.Windows.Forms.ToolStripButton ToolStripAddApp;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewName;
        private System.Windows.Forms.ContextMenuStrip AppContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AppContextMenuStripRemove;
        private System.Windows.Forms.ContextMenuStrip GeneralContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem GeneralContextMenuStripAddApp;
    }
}