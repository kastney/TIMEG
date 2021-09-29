using System;
using System.Linq;
using System.Windows.Forms;

namespace Smad.Pages.Panels.Manual {

    public partial class ChecklistPanel3 : UserControl {

        public ChecklistPanel3() {
            InitializeComponent();
            Builder();
        }

        private void Builder() {
            var body = "";

            body = SetHeader(body);
            body = SetCategories(body);

            body = SetScripts(body);
            var css = @".foot{padding:7px 0;} .center{padding:10px 0;}" + Properties.Resources.StyleSheet;
            string baseHtml = $"<!DOCTYPE html><html><meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"><style>{css}</style><body class=\"w3-container\">{body}</body></html>";
            WebBrowser.DocumentText = baseHtml;
        }

        private string SetHeader(string body) {
            body += "</br>";
            body += "<div class=\"w3-container w3-bar w3-light-grey\">";
            body += "<div class=\"w3-dropdown-click\">";
            body += "<h2 class=\"w3-button\" onclick=\"HeaderFunction()\">";
            body += $"<b>Checklist: {MasterPage.ObjectSerializeManager.Object.Group} <i class=\"fa fa-caret-down\"></i></b>";
            body += "</h2><div id=\"demo\" class=\"w3-dropdown-content w3-bar-block w3-border\">";
            string groupCurrent = "";
            foreach (var item in MasterPage.ObjectSerializeManager.Object.Items) {
                if (!item.Group.Equals(groupCurrent)) {
                    groupCurrent = item.Group;
                    body += $"<a href=\"#\" class=\"w3-bar-item w3-button\">{item.Group}</a>";
                }
            }
            body += "</div></div></div>";
            body += "</br>";
            return body;
        }
        private string SetCategories(string body) {
            string category = "";
            int maxSize = 0;
            int onSize = 0;

            var items = MasterPage.ObjectSerializeManager.Object.Items.Where(a => a.Group.Equals(MasterPage.ObjectSerializeManager.Object.Group)).ToList();
            for (int i = 0; i < items.Count; i++) {
                //Categoria
                if (!category.Equals(items[i].Category)) {
                    category = items[i].Category;
                    body += "<div class=\"w3-container w3-bar w3-light-grey\">";
                    body += $"<h2>Categoria: {category}</h2>";
                }

                body = SetItem(body, items[i]);
                if (items[i].IsError == 1) { onSize++; }
                maxSize++;

                //Finalizando a categoria
                if (i == items.Count - 1 || !category.Equals(items[i + 1].Category)) {
                    body += $"<p class=\"foot\">{onSize} de {maxSize} itens marcados como erros detectados</p>";
                    body += "</div>";
                    body += "<br><br>";
                    maxSize = 0;
                    onSize = 0;
                }
            }

            return body;
        }
        private string SetItem(string body, Entities.Item item) {
            var id = $"{item.Group}#{item.Code}";

            ///Construção do item.
            body += "<br>";
            body += "<div class=\"w3-card-2 w3-white\">";
            body += "<div class=\"w3-panel w3-block\">";
            body += "<div class=\"w3-row\">";
            //Item.
            body += "<div class=\"w3-col l10 s6 center\">";
            body += $"<b>{item.Code} - {item.Name}</b>";
            body += "</div>";
            //Checkbox.
            body += "<div class=\"w3-col l2 s6 center\">";
            if (item.IsError == 1) {
                body += $"É um erro? <input class=\"w3-check\" type=\"checkbox\" onclick=\"AccordionFunction('{id}')\" checked>";
            } else {
                body += $"É um erro? <input class=\"w3-check\" type=\"checkbox\" onclick=\"AccordionFunction('{id}')\">";
            }
            body += "</div></div></div>";

            ///Construção do corpo do item.
            if (item.IsError == 1) {
                body += $"<div id=\"{id}\" class=\"w3-container w3-hide w3-show\">";
            } else {
                body += $"<div id=\"{id}\" class=\"w3-container w3-hide\">";
            }
            body += "<form>";
            //Descrição
            body += "<label for=\"fname\">Descrição do problema:</label><br>";
            body += $"<input class=\"w3-input\" type=\"text\" placeholder=\"A descrição do problema\" value=\"{item.Problem}\"><br>";
            //Localização
            body += "<label for=\"lname\">Localização do problema:</label><br>";
            body += $"<input class=\"w3-input\" type=\"text\" placeholder=\"A descrição da localização do problema\" value=\"{item.Location}\"><br>";
            //Severidade
            body += "<label for=\"lname\">Severidade do problema:</label><br>";
            body += "<select class=\"w3-select\" name=\"option\">";
            if (item.SeverityLevel == -1 || item.SeverityLevel == 0) {
                body += "<option value=\"1\" selected=\"selected\">Baixa</option>";
            } else {
                body += "<option value=\"1\">Baixa</option>";
            }
            if (item.SeverityLevel == 1) {
                body += "<option value=\"2\" selected=\"selected\">Média</option>";
            } else {
                body += "<option value=\"2\">Média</option>";
            }
            if (item.SeverityLevel == 2) {
                body += "<option value=\"3\" selected=\"selected\">Alta</option>";
            } else {
                body += "<option value=\"3\">Alta</option>";
            }
            body += "</select><br><br>";
            body += "</form>";
            body += "</div></div>";

            return body;
        }

        private string SetScripts(string body) {
            body += "<script>";

            //Cabeçalho
            body += "function HeaderFunction() {";
            body += "   var x = document.getElementById(\"demo\");";
            body += "   if (x.className.indexOf(\"w3-show\") == -1) {";
            body += "       x.className += \" w3-show\";";
            body += "   } else {";
            body += "       x.className = x.className.replace(\" w3-show\", \"\");";
            body += "   }";
            body += "}";

            //Acordeão
            body += "function AccordionFunction(id) {";
            body += "   var x = document.getElementById(id);";
            body += "   if (x.className.indexOf(\"w3-show\") == -1) {";
            body += "       x.className += \" w3-show\";";
            body += "   } else {";
            body += "       x.className = x.className.replace(\" w3-show\", \"\");";
            body += "   }";
            body += "}";

            body += "</script>";
            return body;
        }

        ///------------------------------------------------------------------------------

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            WebBrowser.Document.Body.MouseDown += Body_MouseDown;
        }
        private void Body_MouseDown(object sender, HtmlElementEventArgs e) {
            switch (e.MouseButtonsPressed) {
                case MouseButtons.Left: {
                    if (WebBrowser.Document.GetElementFromPoint(e.ClientMousePosition) is HtmlElement element) {

                        if (element.GetAttribute("type").Equals("checkbox", StringComparison.OrdinalIgnoreCase)) {
                            var infor = (element.OuterHtml.Split('\'')[1]).Split('#');
                            var item = MasterPage.ObjectSerializeManager.Object.Items.FirstOrDefault(a => a.Group.Equals(infor[0]) && a.Code.Equals(infor[1]));
                            var index = MasterPage.ObjectSerializeManager.Object.Items.IndexOf(item);
                            if (MasterPage.ObjectSerializeManager.Object.Items[index].IsError == 1) {
                                MasterPage.ObjectSerializeManager.Object.Items[index].IsError = -1;
                            } else {
                                MasterPage.ObjectSerializeManager.Object.Items[index].IsError = 1;
                            }
                            MasterPage.ObjectSerializeManager.SaveObject();
                        }

                    }
                    break;
                }
            }
        }
    }
}
