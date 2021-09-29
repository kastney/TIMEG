namespace Smad.Pages.Panels.Automatic {
    partial class ChecklistPanel {
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
            this.ListView = new LiveShowStudio.Modules.ObjectListView.ObjectListView();
            this.olvColumn1 = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.olvColumn3 = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.olvColumn2 = ((LiveShowStudio.Modules.ObjectListView.OLVColumn)(new LiveShowStudio.Modules.ObjectListView.OLVColumn()));
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SeverityLevelComboBox = new System.Windows.Forms.ComboBox();
            this.SeverityLevelLabel = new System.Windows.Forms.Label();
            this.LocationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.ProblemRichTextBox = new System.Windows.Forms.RichTextBox();
            this.InspectorComboBox = new System.Windows.Forms.ComboBox();
            this.InspectorLabel = new System.Windows.Forms.Label();
            this.ProblemLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.AllColumns.Add(this.olvColumn1);
            this.ListView.AllColumns.Add(this.olvColumn3);
            this.ListView.AllColumns.Add(this.olvColumn2);
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn3,
            this.olvColumn2});
            this.ListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(0, 28);
            this.ListView.MultiSelect = false;
            this.ListView.Name = "ListView";
            this.ListView.RowHeight = 50;
            this.ListView.Size = new System.Drawing.Size(400, 791);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Category";
            this.olvColumn1.Text = "Categoria";
            this.olvColumn1.Width = 0;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "";
            this.olvColumn3.Groupable = false;
            this.olvColumn3.IsEditable = false;
            this.olvColumn3.Text = "";
            this.olvColumn3.Width = 25;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Name";
            this.olvColumn2.FillsFreeSpace = true;
            this.olvColumn2.Groupable = false;
            this.olvColumn2.Text = "Item";
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.ListView);
            this.SplitContainer.Panel1.Controls.Add(this.GroupComboBox);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.panel1);
            this.SplitContainer.Size = new System.Drawing.Size(754, 819);
            this.SplitContainer.SplitterDistance = 400;
            this.SplitContainer.TabIndex = 1;
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(0, 0);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(400, 28);
            this.GroupComboBox.TabIndex = 1;
            this.GroupComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(25);
            this.panel1.Size = new System.Drawing.Size(350, 819);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RemoveButton);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.SeverityLevelComboBox);
            this.panel2.Controls.Add(this.SeverityLevelLabel);
            this.panel2.Controls.Add(this.LocationRichTextBox);
            this.panel2.Controls.Add(this.LocationLabel);
            this.panel2.Controls.Add(this.ProblemRichTextBox);
            this.panel2.Controls.Add(this.InspectorComboBox);
            this.panel2.Controls.Add(this.InspectorLabel);
            this.panel2.Controls.Add(this.ProblemLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(25, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 569);
            this.panel2.TabIndex = 5;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(210, 536);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(87, 30);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.Text = "Remover";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(0, 522);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SeverityLevelComboBox
            // 
            this.SeverityLevelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeverityLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeverityLevelComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeverityLevelComboBox.FormattingEnabled = true;
            this.SeverityLevelComboBox.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.SeverityLevelComboBox.Location = new System.Drawing.Point(0, 450);
            this.SeverityLevelComboBox.Name = "SeverityLevelComboBox";
            this.SeverityLevelComboBox.Size = new System.Drawing.Size(300, 28);
            this.SeverityLevelComboBox.TabIndex = 9;
            this.SeverityLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.SeverityLevelComboBox_SelectedIndexChanged);
            // 
            // SeverityLevelLabel
            // 
            this.SeverityLevelLabel.AutoSize = true;
            this.SeverityLevelLabel.Location = new System.Drawing.Point(6, 427);
            this.SeverityLevelLabel.Name = "SeverityLevelLabel";
            this.SeverityLevelLabel.Size = new System.Drawing.Size(219, 20);
            this.SeverityLevelLabel.TabIndex = 10;
            this.SeverityLevelLabel.Text = "Nível de severidade/prioridade";
            // 
            // LocationRichTextBox
            // 
            this.LocationRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationRichTextBox.Location = new System.Drawing.Point(0, 280);
            this.LocationRichTextBox.Name = "LocationRichTextBox";
            this.LocationRichTextBox.Size = new System.Drawing.Size(297, 115);
            this.LocationRichTextBox.TabIndex = 8;
            this.LocationRichTextBox.Text = "";
            this.LocationRichTextBox.Leave += new System.EventHandler(this.LocationRichTextBox_Leave);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(6, 257);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(185, 20);
            this.LocationLabel.TabIndex = 7;
            this.LocationLabel.Text = "Localização do problema";
            // 
            // ProblemRichTextBox
            // 
            this.ProblemRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProblemRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProblemRichTextBox.Location = new System.Drawing.Point(0, 114);
            this.ProblemRichTextBox.Name = "ProblemRichTextBox";
            this.ProblemRichTextBox.Size = new System.Drawing.Size(297, 115);
            this.ProblemRichTextBox.TabIndex = 6;
            this.ProblemRichTextBox.Text = "";
            this.ProblemRichTextBox.Leave += new System.EventHandler(this.ProblemRichTextBox_Leave);
            // 
            // InspectorComboBox
            // 
            this.InspectorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InspectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InspectorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InspectorComboBox.FormattingEnabled = true;
            this.InspectorComboBox.Items.AddRange(new object[] {
            "O aplicativo está em acordo com esse item ",
            "O aplicativo está em desacordo com esse item"});
            this.InspectorComboBox.Location = new System.Drawing.Point(0, 37);
            this.InspectorComboBox.Name = "InspectorComboBox";
            this.InspectorComboBox.Size = new System.Drawing.Size(300, 28);
            this.InspectorComboBox.TabIndex = 3;
            this.InspectorComboBox.SelectedIndexChanged += new System.EventHandler(this.InspectorComboBox_SelectedIndexChanged);
            // 
            // InspectorLabel
            // 
            this.InspectorLabel.AutoSize = true;
            this.InspectorLabel.Location = new System.Drawing.Point(6, 14);
            this.InspectorLabel.Name = "InspectorLabel";
            this.InspectorLabel.Size = new System.Drawing.Size(160, 20);
            this.InspectorLabel.TabIndex = 4;
            this.InspectorLabel.Text = "Avaliação do inspetor";
            // 
            // ProblemLabel
            // 
            this.ProblemLabel.AutoSize = true;
            this.ProblemLabel.Location = new System.Drawing.Point(6, 91);
            this.ProblemLabel.Name = "ProblemLabel";
            this.ProblemLabel.Size = new System.Drawing.Size(172, 20);
            this.ProblemLabel.TabIndex = 5;
            this.ProblemLabel.Text = "Descrição do problema";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CodeLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CategoryLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 200);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CodeLabel
            // 
            this.CodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeLabel.Location = new System.Drawing.Point(153, 140);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(144, 60);
            this.CodeLabel.TabIndex = 1;
            this.CodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryLabel.Location = new System.Drawing.Point(3, 140);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(144, 60);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.NameLabel, 2);
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(294, 140);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChecklistPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitContainer);
            this.Name = "ChecklistPanel";
            this.Size = new System.Drawing.Size(754, 819);
            this.Load += new System.EventHandler(this.ChecklistPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).EndInit();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveShowStudio.Modules.ObjectListView.ObjectListView ListView;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn olvColumn1;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn olvColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox InspectorComboBox;
        private System.Windows.Forms.Label InspectorLabel;
        private System.Windows.Forms.RichTextBox ProblemRichTextBox;
        private System.Windows.Forms.Label ProblemLabel;
        private System.Windows.Forms.RichTextBox LocationRichTextBox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.ComboBox SeverityLevelComboBox;
        private System.Windows.Forms.Label SeverityLevelLabel;
        private LiveShowStudio.Modules.ObjectListView.OLVColumn olvColumn3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ComboBox GroupComboBox;
    }
}
