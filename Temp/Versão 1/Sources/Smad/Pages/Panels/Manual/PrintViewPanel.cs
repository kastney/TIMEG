using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System;

namespace Smad.Pages.Panels.Manual {

    public partial class PrintViewPanel : UserControl {

        public PrintViewPanel() {
            InitializeComponent();
            ReportBuider();
        }

        private void ReportBuider() {
            var body = "";

            body = SetSeverity(body, MasterPage.ObjectSerializeManager.Object.Items.ToList().Where(a => a.Group.Equals(MasterPage.ObjectSerializeManager.Object.Group) && a.IsError == 1 && a.SeverityLevel == 2).ToList(), "w3-pale-red");
            body = SetSeverity(body, MasterPage.ObjectSerializeManager.Object.Items.ToList().Where(a => a.Group.Equals(MasterPage.ObjectSerializeManager.Object.Group) && a.IsError == 1 && a.SeverityLevel == 1).ToList(), "w3-pale-yellow");
            body = SetSeverity(body, MasterPage.ObjectSerializeManager.Object.Items.ToList().Where(a => a.Group.Equals(MasterPage.ObjectSerializeManager.Object.Group) && a.IsError == 1 && (a.SeverityLevel == 0 || a.SeverityLevel == -1)).ToList(), "w3-pale-blue");

            #region Footer
            body += "<div class=\"w3-container\"></div>";
            #endregion

            string back = ColorTranslator.ToHtml(Color.FromArgb(SystemColors.Control.ToArgb()));
            var css = @"h3{text-align:center;}p{text-align:justify;margin-top:0;}body{background-color:" + back + ";}" + Properties.Resources.StyleSheet;
            string baseHtml = $"<!DOCTYPE html><html><head><style>{css}</style></head><body class=\"w3-container\"><div class=\"w3-container\"><h1><b>Relatório de erros</b></h1><p><b>Aplicativo:</b> {MasterPage.ObjectSerializeManager.Object.Name}<br/><b>Data da inspeção:</b> {DateTime.Now.Date.ToLongDateString()}<br/><b>Tempo médio da inspeção:</b> {MasterPage.ObjectSerializeManager.Object.Stopwatch.ToLongTimeString()}<br/><b>Técnica utilizada:</b> {MasterPage.ObjectSerializeManager.Object.Group}</p></div>{body}</body></html>";
            WebBrowser.DocumentText = baseHtml;
        }
        private string SetSeverity(string body, List<Entities.Item> items, string color) {
            if (items is null || items.Count == 0) { return body; }

            var currentCategory = "";
            //Mostrando os itens de alta severidade.
            body += $"<div class=\"w3-container {color} w3-border w3-round-large w3-margin-bottom\">";
            var severity = string.IsNullOrEmpty(items[0].Severity) ? "Baixa" : items[0].Severity;
            body += $"<h2><b>Severidade:</b> {severity}</h2>";

            //Os itens com alta severidade.
            for (int i = 0; i < items.Count; i++) {
                //Iniciando a divisória de categoria.
                if (!currentCategory.Equals(items[i].Category)) {
                    currentCategory = items[i].Category;
                    body += "<div class=\"w3-panel w3-white w3-border w3-round-large\">";
                    body += $"<h3><b>{items[i].Category}</b></h3>";
                }

                ///Conteúdo do item.
                body += $"<div><h4><b><i>{items[i].Code} - {items[i].Name}</i></b></h4>";
                if (!string.IsNullOrEmpty(items[i].Problem)) {
                    body += $"<b>Descrição do problema</b><p><i>{items[i].Problem}</i></p>";
                } else {
                    body += "<b>Descrição do problema</b><p><i>Descrição não informada...</i></p>";
                }
                if (!string.IsNullOrEmpty(items[i].Location)) {
                    body += $"<b>Localização do problema</b><p><i>{items[i].Location}</i></p>";
                } else {
                    body += "<b>Localização do problema</b><p><i>Localização não informada...</i></p>";
                }
                if (items[i].Print != null) {
                    var converter = new ImageConverter();
                    var pictureBox = new PictureBox {
                        Image = (Image)converter.ConvertFrom(items[i].Print)
                    };
                    var dirImage = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Smad\Temp\Image\";
                    System.IO.Directory.CreateDirectory(dirImage);
                    dirImage += $"{items[i].Code}.jpeg";
                    pictureBox.Image.Save(dirImage, System.Drawing.Imaging.ImageFormat.Jpeg);
                    body += $"<img src=\"{dirImage}\" height=\"500\" style=\"display: block;margin-left: auto;margin-right: auto;\">";
                }
                body += "</div>";

                //Finalizando a divisória de categoria.
                if (i == items.Count - 1 || !currentCategory.Equals(items[i + 1].Category)) {
                    body += "</div>";
                }
            }

            //Finalizando o card de alta severidade.
            body += "</div>";

            return body;
        }

        private void ToolStripPrint_Click(object sender, System.EventArgs e) {
            WebBrowser.ShowPrintPreviewDialog();
        }
    }
}