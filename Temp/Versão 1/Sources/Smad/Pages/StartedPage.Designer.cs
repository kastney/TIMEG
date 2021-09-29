namespace Smad.Pages {
    partial class StartedPage {
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
            this.ListView = new LiveShowStudio.Modules.ObjectListView.ObjectListView();
            this.ListViewOptions = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ContentPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.AllColumns.Add(this.ListViewOptions);
            this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListViewOptions});
            this.ListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListView.FullRowSelect = true;
            this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(0, 0);
            this.ListView.MultiSelect = false;
            this.ListView.Name = "ListView";
            this.ListView.RowHeight = 50;
            this.ListView.Size = new System.Drawing.Size(250, 1024);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectionChanged += new System.EventHandler(this.ListView_SelectionChanged);
            this.ListView.Click += new System.EventHandler(this.ListView_Click);
            // 
            // ListViewOptions
            // 
            this.ListViewOptions.AspectName = "Name";
            this.ListViewOptions.FillsFreeSpace = true;
            this.ListViewOptions.Groupable = false;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(250, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1648, 1024);
            this.ContentPanel.TabIndex = 0;
            // 
            // StartedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.ListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartedPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smad";
            this.Load += new System.EventHandler(this.StartedPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LiveShowStudio.Modules.ObjectListView.ObjectListView ListView;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewOptions;
        private System.Windows.Forms.Panel ContentPanel;
    }
}