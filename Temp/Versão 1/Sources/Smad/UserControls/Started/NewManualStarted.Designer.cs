namespace Smad.UserControls.Started {
    partial class NewManualStarted {
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
            this.BackButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.DirectoryText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AppIdText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AppStoreComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(38, 26);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(179, 32);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Novo Projeto";
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BackButton.Location = new System.Drawing.Point(480, 603);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(140, 42);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Voltar";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.Enabled = false;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(626, 603);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(140, 42);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Criar";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DirectoryButton.Location = new System.Drawing.Point(669, 473);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(75, 30);
            this.DirectoryButton.TabIndex = 18;
            this.DirectoryButton.Text = "•••";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // DirectoryText
            // 
            this.DirectoryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectoryText.Location = new System.Drawing.Point(50, 473);
            this.DirectoryText.Name = "DirectoryText";
            this.DirectoryText.ReadOnly = true;
            this.DirectoryText.Size = new System.Drawing.Size(613, 26);
            this.DirectoryText.TabIndex = 17;
            this.DirectoryText.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Diretório onde irá salvar o projeto";
            // 
            // AppIdText
            // 
            this.AppIdText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppIdText.Location = new System.Drawing.Point(49, 175);
            this.AppIdText.Name = "AppIdText";
            this.AppIdText.Size = new System.Drawing.Size(695, 26);
            this.AppIdText.TabIndex = 15;
            this.AppIdText.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nome do aplicativo";
            // 
            // AppStoreComboBox
            // 
            this.AppStoreComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppStoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppStoreComboBox.FormattingEnabled = true;
            this.AppStoreComboBox.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.AppStoreComboBox.Location = new System.Drawing.Point(50, 271);
            this.AppStoreComboBox.Name = "AppStoreComboBox";
            this.AppStoreComboBox.Size = new System.Drawing.Size(694, 28);
            this.AppStoreComboBox.TabIndex = 20;
            this.AppStoreComboBox.SelectedValueChanged += new System.EventHandler(this.AppStoreComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Esse aplicativo está disponível na Google Play Store?";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(50, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(666, 26);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Identificador do aplicativo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Smad.Properties.Resources.icon_info;
            this.pictureBox1.Location = new System.Drawing.Point(721, 373);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(698, 41);
            this.label5.TabIndex = 24;
            this.label5.Text = "*se o identificador do aplicativo for informado será possível apresentar informaç" +
    "ões como nuvem de palavras e comentários";
            // 
            // NewManualStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AppStoreComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DirectoryButton);
            this.Controls.Add(this.DirectoryText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AppIdText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.label5);
            this.Name = "NewManualStarted";
            this.Size = new System.Drawing.Size(800, 665);
            this.Load += new System.EventHandler(this.NewManualStarted_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.TextBox DirectoryText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AppIdText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AppStoreComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}
