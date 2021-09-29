namespace Smad.Pages {
    partial class SettingsPage {
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
            this.OptionsListView = new LiveShowStudio.Modules.ObjectListView.FastObjectListView();
            this.olvColumn1 = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsListView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsListView
            // 
            this.OptionsListView.AllColumns.Add(this.olvColumn1);
            this.OptionsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionsListView.CellEditUseWholeCell = false;
            this.OptionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1});
            this.OptionsListView.CopySelectionOnControlC = false;
            this.OptionsListView.CopySelectionOnControlCUsesDragSource = false;
            this.OptionsListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.OptionsListView.FullRowSelect = true;
            this.OptionsListView.HasCollapsibleGroups = false;
            this.OptionsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.OptionsListView.HideSelection = false;
            this.OptionsListView.IsSearchOnSortColumn = false;
            this.OptionsListView.Location = new System.Drawing.Point(12, 12);
            this.OptionsListView.MultiSelect = false;
            this.OptionsListView.Name = "OptionsListView";
            this.OptionsListView.PersistentCheckBoxes = false;
            this.OptionsListView.RowHeight = 35;
            this.OptionsListView.SelectAllOnControlA = false;
            this.OptionsListView.SelectColumnsMenuStaysOpen = false;
            this.OptionsListView.SelectColumnsOnRightClick = false;
            this.OptionsListView.SelectColumnsOnRightClickBehaviour = LiveShowStudio.Modules.ObjectListView.ObjectListView.ColumnSelectBehaviour.None;
            this.OptionsListView.SelectedBackColor = System.Drawing.Color.DodgerBlue;
            this.OptionsListView.SelectedForeColor = System.Drawing.Color.White;
            this.OptionsListView.ShowFilterMenuOnRightClick = false;
            this.OptionsListView.ShowGroups = false;
            this.OptionsListView.ShowHeaderInAllViews = false;
            this.OptionsListView.ShowSortIndicators = false;
            this.OptionsListView.Size = new System.Drawing.Size(257, 640);
            this.OptionsListView.SortGroupItemsByPrimaryColumn = false;
            this.OptionsListView.TabIndex = 0;
            this.OptionsListView.UseCompatibleStateImageBehavior = false;
            this.OptionsListView.UseHotControls = false;
            this.OptionsListView.UseOverlays = false;
            this.OptionsListView.View = System.Windows.Forms.View.Details;
            this.OptionsListView.VirtualMode = true;
            this.OptionsListView.SelectionChanged += new System.EventHandler(this.OptionsListView_SelectionChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Name";
            this.olvColumn1.FillsFreeSpace = true;
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(275, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(783, 664);
            this.ContentPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OptionsListView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 664);
            this.panel1.TabIndex = 0;
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            ((System.ComponentModel.ISupportInitialize)(this.OptionsListView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveShowStudio.Modules.ObjectListView.FastObjectListView OptionsListView;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn olvColumn1;
        private System.Windows.Forms.FlowLayoutPanel ContentPanel;
        private System.Windows.Forms.Panel panel1;
    }
}