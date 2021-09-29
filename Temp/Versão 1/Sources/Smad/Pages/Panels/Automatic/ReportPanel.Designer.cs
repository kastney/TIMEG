namespace Smad.Pages.Panels.Automatic {
    partial class ReportPanel {
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.CardViewList = new Smad.UserControls.CardViewList();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(315, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(485, 500);
            this.ContentPanel.TabIndex = 1;
            // 
            // CardViewList
            // 
            this.CardViewList.AutoScroll = true;
            this.CardViewList.BackColor = System.Drawing.SystemColors.Control;
            this.CardViewList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardViewList.Dock = System.Windows.Forms.DockStyle.Left;
            this.CardViewList.IsUnselected = true;
            this.CardViewList.Location = new System.Drawing.Point(0, 0);
            this.CardViewList.Name = "CardViewList";
            this.CardViewList.SelectedCard = null;
            this.CardViewList.Size = new System.Drawing.Size(315, 500);
            this.CardViewList.TabIndex = 0;
            // 
            // ReportPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.CardViewList);
            this.Name = "ReportPanel";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.ReportPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.CardViewList CardViewList;
        private System.Windows.Forms.Panel ContentPanel;
    }
}
