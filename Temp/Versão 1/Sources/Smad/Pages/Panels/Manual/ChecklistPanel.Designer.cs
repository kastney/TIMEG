
namespace Smad.Pages.Panels.Manual {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Accordion = new Opulos.Core.UI.Accordion();
            this.StartButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.GroupComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 188);
            this.panel1.TabIndex = 1;
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(25, 92);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(309, 54);
            this.GroupComboBox.TabIndex = 2;
            this.GroupComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione o checklist";
            // 
            // Accordion
            // 
            this.Accordion.AddResizeBars = true;
            this.Accordion.AllowMouseResize = true;
            this.Accordion.AnimateCloseEffect = ((Opulos.Core.UI.AnimateWindowFlags)(((Opulos.Core.UI.AnimateWindowFlags.VerticalNegative | Opulos.Core.UI.AnimateWindowFlags.Hide) 
            | Opulos.Core.UI.AnimateWindowFlags.Slide)));
            this.Accordion.AnimateCloseMillis = 300;
            this.Accordion.AnimateOpenEffect = ((Opulos.Core.UI.AnimateWindowFlags)(((Opulos.Core.UI.AnimateWindowFlags.VerticalPositive | Opulos.Core.UI.AnimateWindowFlags.Show) 
            | Opulos.Core.UI.AnimateWindowFlags.Slide)));
            this.Accordion.AnimateOpenMillis = 300;
            this.Accordion.AutoFixDockStyle = true;
            this.Accordion.AutoScroll = true;
            this.Accordion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Accordion.CheckBoxFactory = null;
            this.Accordion.CheckBoxMargin = new System.Windows.Forms.Padding(0);
            this.Accordion.ContentBackColor = null;
            this.Accordion.ContentMargin = null;
            this.Accordion.ContentPadding = new System.Windows.Forms.Padding(6);
            this.Accordion.ControlBackColor = null;
            this.Accordion.ControlMinimumHeightIsItsPreferredHeight = true;
            this.Accordion.ControlMinimumWidthIsItsPreferredWidth = true;
            this.Accordion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Accordion.DownArrow = "";
            this.Accordion.FillHeight = true;
            this.Accordion.FillLastOpened = false;
            this.Accordion.FillModeGrowOnly = false;
            this.Accordion.FillResetOnCollapse = false;
            this.Accordion.FillWidth = true;
            this.Accordion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accordion.GrabCursor = System.Windows.Forms.Cursors.SizeNS;
            this.Accordion.GrabRequiresPositiveFillWeight = true;
            this.Accordion.GrabWidth = 7;
            this.Accordion.GrowAndShrink = true;
            this.Accordion.Insets = new System.Windows.Forms.Padding(0);
            this.Accordion.Location = new System.Drawing.Point(0, 189);
            this.Accordion.Name = "Accordion";
            this.Accordion.OpenOnAdd = false;
            this.Accordion.OpenOneOnly = false;
            this.Accordion.ResizeBarFactory = null;
            this.Accordion.ResizeBarsAlign = 0.5D;
            this.Accordion.ResizeBarsArrowKeyDelta = 12;
            this.Accordion.ResizeBarsFadeInMillis = 800;
            this.Accordion.ResizeBarsFadeOutMillis = 800;
            this.Accordion.ResizeBarsFadeProximity = 36;
            this.Accordion.ResizeBarsFill = 1D;
            this.Accordion.ResizeBarsKeepFocusAfterMouseDrag = false;
            this.Accordion.ResizeBarsKeepFocusIfControlOutOfView = true;
            this.Accordion.ResizeBarsKeepFocusOnClick = true;
            this.Accordion.ResizeBarsMargin = null;
            this.Accordion.ResizeBarsMinimumLength = 60;
            this.Accordion.ResizeBarsStayInViewOnArrowKey = true;
            this.Accordion.ResizeBarsStayInViewOnMouseDrag = true;
            this.Accordion.ResizeBarsStayVisibleIfFocused = true;
            this.Accordion.ResizeBarsTabStop = true;
            this.Accordion.ShowPartiallyVisibleResizeBars = false;
            this.Accordion.ShowToolMenu = true;
            this.Accordion.ShowToolMenuOnHoverWhenClosed = false;
            this.Accordion.ShowToolMenuOnRightClick = true;
            this.Accordion.ShowToolMenuRequiresPositiveFillWeight = false;
            this.Accordion.Size = new System.Drawing.Size(833, 213);
            this.Accordion.TabIndex = 0;
            this.Accordion.UpArrow = "";
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.StartButton.Location = new System.Drawing.Point(340, 90);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(259, 66);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Iniciar";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 1);
            this.panel2.TabIndex = 5;
            // 
            // ChecklistPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Accordion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChecklistPanel";
            this.Size = new System.Drawing.Size(833, 402);
            this.Load += new System.EventHandler(this.ChecklistPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Opulos.Core.UI.Accordion Accordion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel panel2;
    }
}
