namespace Smad.Pages.Panels.Automatic {
    partial class CommentsPanel {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.ListView = new LiveShowStudio.Modules.ObjectListView.ObjectListView();
            this.ListViewUserName = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ListViewMessage = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ListViewRating = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ListViewLike = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ListViewPublishDate = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuStripExport = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripExportSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuStripExportCSV = new System.Windows.Forms.ToolStripTextBox();
            this.ContextMenuStripExportSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).BeginInit();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.AllColumns.Add(this.ListViewUserName);
            this.ListView.AllColumns.Add(this.ListViewMessage);
            this.ListView.AllColumns.Add(this.ListViewRating);
            this.ListView.AllColumns.Add(this.ListViewLike);
            this.ListView.AllColumns.Add(this.ListViewPublishDate);
            this.ListView.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListViewUserName,
            this.ListViewMessage,
            this.ListViewRating,
            this.ListViewLike,
            this.ListViewPublishDate});
            this.ListView.ContextMenuStrip = this.ContextMenuStrip;
            this.ListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(53, 115);
            this.ListView.Name = "ListView";
            this.ListView.RowHeight = 90;
            this.ListView.ShowGroups = false;
            this.ListView.Size = new System.Drawing.Size(974, 552);
            this.ListView.TabIndex = 0;
            this.ListView.UseAlternatingBackColors = true;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // ListViewUserName
            // 
            this.ListViewUserName.AspectName = "UserName";
            this.ListViewUserName.Groupable = false;
            this.ListViewUserName.IsEditable = false;
            this.ListViewUserName.Text = "Usuário";
            this.ListViewUserName.Width = 100;
            // 
            // ListViewMessage
            // 
            this.ListViewMessage.AspectName = "Message";
            this.ListViewMessage.FillsFreeSpace = true;
            this.ListViewMessage.Groupable = false;
            this.ListViewMessage.IsEditable = false;
            this.ListViewMessage.Text = "Comentário";
            this.ListViewMessage.WordWrap = true;
            // 
            // ListViewRating
            // 
            this.ListViewRating.AspectName = "Rating";
            this.ListViewRating.IsEditable = false;
            this.ListViewRating.Text = "Classificação";
            this.ListViewRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ListViewRating.Width = 110;
            // 
            // ListViewLike
            // 
            this.ListViewLike.AspectName = "Like";
            this.ListViewLike.Groupable = false;
            this.ListViewLike.IsEditable = false;
            this.ListViewLike.Text = "Like";
            this.ListViewLike.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ListViewPublishDate
            // 
            this.ListViewPublishDate.AspectName = "PublishDate";
            this.ListViewPublishDate.IsEditable = false;
            this.ListViewPublishDate.Text = "Publicação";
            this.ListViewPublishDate.Width = 120;
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuStripExport});
            this.ContextMenuStrip.Name = "contextMenuStrip1";
            this.ContextMenuStrip.Size = new System.Drawing.Size(185, 36);
            // 
            // ContextMenuStripExport
            // 
            this.ContextMenuStripExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuStripExportSeparator1,
            this.ContextMenuStripExportCSV,
            this.ContextMenuStripExportSeparator2});
            this.ContextMenuStripExport.Name = "ContextMenuStripExport";
            this.ContextMenuStripExport.Size = new System.Drawing.Size(184, 32);
            this.ContextMenuStripExport.Text = "Exportar .csv";
            // 
            // ContextMenuStripExportSeparator1
            // 
            this.ContextMenuStripExportSeparator1.Name = "ContextMenuStripExportSeparator1";
            this.ContextMenuStripExportSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // ContextMenuStripExportCSV
            // 
            this.ContextMenuStripExportCSV.Name = "ContextMenuStripExportCSV";
            this.ContextMenuStripExportCSV.Size = new System.Drawing.Size(100, 31);
            this.ContextMenuStripExportCSV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExportCSV_KeyDown);
            // 
            // ContextMenuStripExportSeparator2
            // 
            this.ContextMenuStripExportSeparator2.Name = "ContextMenuStripExportSeparator2";
            this.ContextMenuStripExportSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // SearchText
            // 
            this.SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(533, 53);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(494, 44);
            this.SearchText.TabIndex = 1;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar";
            // 
            // CommentsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.ListView);
            this.Name = "CommentsPanel";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Size = new System.Drawing.Size(1080, 720);
            this.Load += new System.EventHandler(this.CommentsPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).EndInit();
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveShowStudio.Modules.ObjectListView.ObjectListView ListView;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewUserName;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewMessage;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewRating;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewLike;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewPublishDate;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuStripExport;
        private System.Windows.Forms.ToolStripTextBox ContextMenuStripExportCSV;
        private System.Windows.Forms.ToolStripSeparator ContextMenuStripExportSeparator1;
        private System.Windows.Forms.ToolStripSeparator ContextMenuStripExportSeparator2;
    }
}
