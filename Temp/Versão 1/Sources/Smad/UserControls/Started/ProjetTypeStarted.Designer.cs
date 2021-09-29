namespace Smad.UserControls.Started {
    partial class ProjetTypeStarted {
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
            this.NextButton = new System.Windows.Forms.Button();
            this.CardViewList = new Smad.UserControls.CardViewList();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(38, 26);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(179, 32);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Novo Projeto";
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NextButton.Location = new System.Drawing.Point(626, 603);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(140, 42);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Avançar";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CardViewList
            // 
            this.CardViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardViewList.AutoScroll = true;
            this.CardViewList.IsUnselected = true;
            this.CardViewList.Location = new System.Drawing.Point(3, 77);
            this.CardViewList.Name = "CardViewList";
            this.CardViewList.Padding = new System.Windows.Forms.Padding(10);
            this.CardViewList.SelectedCard = null;
            this.CardViewList.Size = new System.Drawing.Size(794, 520);
            this.CardViewList.TabIndex = 2;
            // 
            // ProjetTypeStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CardViewList);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ProjetTypeStarted";
            this.Size = new System.Drawing.Size(800, 665);
            this.Load += new System.EventHandler(this.ProjetTypeStarted_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button NextButton;
        private CardViewList CardViewList;
    }
}
