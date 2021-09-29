namespace Smad.UserControls.Settings {
    partial class GeneralSetting {
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
            this.GeneralGroup = new System.Windows.Forms.GroupBox();
            this.ThemeOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GeneralGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralGroup
            // 
            this.GeneralGroup.Controls.Add(this.label1);
            this.GeneralGroup.Controls.Add(this.ThemeOptions);
            this.GeneralGroup.Location = new System.Drawing.Point(33, 23);
            this.GeneralGroup.Name = "GeneralGroup";
            this.GeneralGroup.Padding = new System.Windows.Forms.Padding(30);
            this.GeneralGroup.Size = new System.Drawing.Size(714, 132);
            this.GeneralGroup.TabIndex = 0;
            this.GeneralGroup.TabStop = false;
            this.GeneralGroup.Text = "Configurações gerais";
            // 
            // ThemeOptions
            // 
            this.ThemeOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemeOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeOptions.FormattingEnabled = true;
            this.ThemeOptions.Items.AddRange(new object[] {
            "Claro",
            "Escuro"});
            this.ThemeOptions.Location = new System.Drawing.Point(139, 53);
            this.ThemeOptions.Name = "ThemeOptions";
            this.ThemeOptions.Size = new System.Drawing.Size(542, 28);
            this.ThemeOptions.TabIndex = 0;
            this.ThemeOptions.SelectedIndexChanged += new System.EventHandler(this.ThemeOptions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GeneralSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GeneralGroup);
            this.Name = "GeneralSetting";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 0, 30);
            this.Size = new System.Drawing.Size(750, 226);
            this.GeneralGroup.ResumeLayout(false);
            this.GeneralGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GeneralGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ThemeOptions;
    }
}
