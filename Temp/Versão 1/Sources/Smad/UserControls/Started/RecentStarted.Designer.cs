namespace Smad.UserControls.Started {
    partial class RecentStarted {
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ListView = new LiveShowStudio.Modules.ObjectListView.ObjectListView();
            this.olvColumn2 = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.ListViewMain = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.DescribedTaskRenderer = new LiveShowStudio.Modules.ObjectListView.DescribedTaskRenderer();
            this.ListViewDate = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.olvColumn1 = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.HotItemStyle = new LiveShowStudio.Modules.ObjectListView.HotItemStyle();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(38, 26);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(202, 32);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Abrir Recentes";
            // 
            // ListView
            // 
            this.ListView.AllColumns.Add(this.olvColumn2);
            this.ListView.AllColumns.Add(this.ListViewMain);
            this.ListView.AllColumns.Add(this.ListViewDate);
            this.ListView.AllColumns.Add(this.olvColumn1);
            this.ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2,
            this.ListViewMain,
            this.ListViewDate,
            this.olvColumn1});
            this.ListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListView.EmptyListMsg = "Nenhum projeto criado até o momento";
            this.ListView.FullRowSelect = true;
            this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView.HideSelection = false;
            this.ListView.HotItemStyle = this.HotItemStyle;
            this.ListView.Location = new System.Drawing.Point(27, 103);
            this.ListView.MultiSelect = false;
            this.ListView.Name = "ListView";
            this.ListView.RowHeight = 50;
            this.ListView.Size = new System.Drawing.Size(746, 535);
            this.ListView.TabIndex = 1;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.UseHotItem = true;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.ButtonClick += new System.EventHandler<LiveShowStudio.Modules.ObjectListView.CellClickEventArgs>(this.OnRemoveRecentObject);
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "ProjectType";
            this.olvColumn2.Width = 0;
            // 
            // ListViewMain
            // 
            this.ListViewMain.AspectName = "Name";
            this.ListViewMain.FillsFreeSpace = true;
            this.ListViewMain.Groupable = false;
            this.ListViewMain.Renderer = this.DescribedTaskRenderer;
            // 
            // DescribedTaskRenderer
            // 
            this.DescribedTaskRenderer.CellPadding = new System.Drawing.Rectangle(9, 9, 0, 0);
            this.DescribedTaskRenderer.CellVerticalAlignment = System.Drawing.StringAlignment.Near;
            this.DescribedTaskRenderer.DescriptionAspectName = "Directory";
            this.DescribedTaskRenderer.DescriptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescribedTaskRenderer.ImageTextSpace = 7;
            this.DescribedTaskRenderer.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ListViewDate
            // 
            this.ListViewDate.AspectName = "LastAcess";
            this.ListViewDate.Groupable = false;
            this.ListViewDate.Width = 120;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Button";
            this.olvColumn1.ButtonMaxWidth = 10;
            this.olvColumn1.ButtonSize = new System.Drawing.Size(20, 20);
            this.olvColumn1.ButtonSizing = LiveShowStudio.Modules.ObjectListView.OLVColumn.ButtonSizingMode.FixedBounds;
            this.olvColumn1.IsButton = true;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Width = 28;
            // 
            // HotItemStyle
            // 
            this.HotItemStyle.BackColor = System.Drawing.SystemColors.Highlight;
            // 
            // RecentStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.TitleLabel);
            this.Name = "RecentStarted";
            this.Size = new System.Drawing.Size(800, 665);
            this.Load += new System.EventHandler(this.RecentStarted_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private LiveShowStudio.Modules.ObjectListView.ObjectListView ListView;
        private LiveShowStudio.Modules.ObjectListView.DescribedTaskRenderer DescribedTaskRenderer;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewMain;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn ListViewDate;
        private LiveShowStudio.Modules.ObjectListView.HotItemStyle HotItemStyle;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn olvColumn1;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn olvColumn2;
    }
}
