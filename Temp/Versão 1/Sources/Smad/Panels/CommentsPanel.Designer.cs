namespace Smad.Panels {
    partial class CommentsPanel {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentsPanel));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripInit = new System.Windows.Forms.ToolStripButton();
            this.ToolStripPlus = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripPlusExport = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripPlusExportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.ListView = new LiveShowStudio.Modules.ObjectListView.FastObjectListView();
            this.ListViewUserName = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ListViewMessage = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ListViewRating = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ListViewLike = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ListViewPublishDate = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripInit,
            this.ToolStripPlus});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(800, 38);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // ToolStripInit
            // 
            this.ToolStripInit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripInit.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripInit.Image")));
            this.ToolStripInit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripInit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripInit.Margin = new System.Windows.Forms.Padding(1, 2, 0, 3);
            this.ToolStripInit.Name = "ToolStripInit";
            this.ToolStripInit.Size = new System.Drawing.Size(34, 33);
            this.ToolStripInit.Click += new System.EventHandler(this.ToolStripInit_Click);
            // 
            // ToolStripPlus
            // 
            this.ToolStripPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripPlus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripPlusExport});
            this.ToolStripPlus.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripPlus.Image")));
            this.ToolStripPlus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripPlus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripPlus.Name = "ToolStripPlus";
            this.ToolStripPlus.Size = new System.Drawing.Size(34, 33);
            this.ToolStripPlus.Text = "toolStripDropDownButton1";
            // 
            // ToolStripPlusExport
            // 
            this.ToolStripPlusExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripPlusExportCSV});
            this.ToolStripPlusExport.Name = "ToolStripPlusExport";
            this.ToolStripPlusExport.Size = new System.Drawing.Size(180, 34);
            this.ToolStripPlusExport.Text = "Exportar";
            // 
            // ToolStripPlusExportCSV
            // 
            this.ToolStripPlusExportCSV.Name = "ToolStripPlusExportCSV";
            this.ToolStripPlusExportCSV.Size = new System.Drawing.Size(139, 34);
            this.ToolStripPlusExportCSV.Text = "csv";
            this.ToolStripPlusExportCSV.Click += new System.EventHandler(this.ToolStripPlusExportCSV_Click);
            // 
            // ListView
            // 
            this.ListView.AllColumns.Add(this.ListViewUserName);
            this.ListView.AllColumns.Add(this.ListViewMessage);
            this.ListView.AllColumns.Add(this.ListViewRating);
            this.ListView.AllColumns.Add(this.ListViewLike);
            this.ListView.AllColumns.Add(this.ListViewPublishDate);
            this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListViewUserName,
            this.ListViewMessage,
            this.ListViewRating});
            this.ListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.EmptyListMsg = "Nenhum comentário";
            this.ListView.FullRowSelect = true;
            this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView.HeaderUsesThemes = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(0, 38);
            this.ListView.Name = "ListView";
            this.ListView.RowHeight = 30;
            this.ListView.SelectColumnsOnRightClick = false;
            this.ListView.SelectColumnsOnRightClickBehaviour = LiveShowStudio.Modules.ObjectListView.ObjectListView.ColumnSelectBehaviour.None;
            this.ListView.ShowGroups = false;
            this.ListView.Size = new System.Drawing.Size(800, 412);
            this.ListView.TabIndex = 1;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.VirtualMode = true;
            // 
            // ListViewUserName
            // 
            this.ListViewUserName.AspectName = "UserName";
            this.ListViewUserName.Text = "Usuário";
            // 
            // ListViewMessage
            // 
            this.ListViewMessage.AspectName = "Message";
            this.ListViewMessage.FillsFreeSpace = true;
            this.ListViewMessage.Text = "Comentário";
            // 
            // ListViewRating
            // 
            this.ListViewRating.AspectName = "Rating";
            this.ListViewRating.Text = "Classificação";
            this.ListViewRating.Width = 30;
            // 
            // ListViewLike
            // 
            this.ListViewLike.AspectName = "Like";
            this.ListViewLike.DisplayIndex = 3;
            this.ListViewLike.IsVisible = false;
            this.ListViewLike.Text = "Like";
            this.ListViewLike.Width = 30;
            // 
            // ListViewPublishDate
            // 
            this.ListViewPublishDate.AspectName = "PublishDate";
            this.ListViewPublishDate.DisplayIndex = 4;
            this.ListViewPublishDate.IsVisible = false;
            this.ListViewPublishDate.Text = "Publicação";
            // 
            // CommentsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.ToolStrip);
            this.Name = "CommentsPanel";
            this.Load += new System.EventHandler(this.CommentsPanel_Load);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private LiveShowStudio.Modules.ObjectListView.FastObjectListView ListView;
        private System.Windows.Forms.ToolStripButton ToolStripInit;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewUserName;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewMessage;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewRating;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewLike;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewPublishDate;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripPlus;
        private System.Windows.Forms.ToolStripMenuItem ToolStripPlusExport;
        private System.Windows.Forms.ToolStripMenuItem ToolStripPlusExportCSV;
    }
}