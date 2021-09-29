namespace Smad.Panels {
    partial class FilterPanel {
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
            this.ListView = new LiveShowStudio.Modules.ObjectListView.FastObjectListView();
            this.ListViewCheck = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ListViewName = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.AllColumns.Add(this.ListViewCheck);
            this.ListView.AllColumns.Add(this.ListViewName);
            this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView.CheckBoxes = true;
            this.ListView.CheckedAspectName = "IsEnabled";
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListViewCheck,
            this.ListViewName});
            this.ListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.EmptyListMsg = "Nenhum filtro";
            this.ListView.FullRowSelect = true;
            this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(0, 38);
            this.ListView.Name = "ListView";
            this.ListView.RowHeight = 30;
            this.ListView.ShowGroups = false;
            this.ListView.ShowImagesOnSubItems = true;
            this.ListView.Size = new System.Drawing.Size(800, 412);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.VirtualMode = true;
            this.ListView.SelectionChanged += new System.EventHandler(this.ListView_SelectionChanged);
            this.ListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListView_ItemChecked);
            // 
            // ListViewCheck
            // 
            this.ListViewCheck.AspectName = "";
            this.ListViewCheck.IsEditable = false;
            this.ListViewCheck.Searchable = false;
            this.ListViewCheck.Width = 20;
            // 
            // ListViewName
            // 
            this.ListViewName.AspectName = "Name";
            this.ListViewName.FillsFreeSpace = true;
            // 
            // ToolStrip
            // 
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(800, 38);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // FilterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.ToolStrip);
            this.Name = "FilterPanel";
            this.ShowHint = LiveShowStudio.Modules.DockPanelSuite.Docking.DockState.DockRight;
            this.Text = "Filtros";
            this.Load += new System.EventHandler(this.FilterPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip ToolStrip;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewName;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewCheck;
        public LiveShowStudio.Modules.ObjectListView.FastObjectListView ListView;
    }
}