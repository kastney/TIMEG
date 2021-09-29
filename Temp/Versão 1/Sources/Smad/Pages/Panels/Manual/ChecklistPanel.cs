using Opulos.Core.UI;
using Smad.Pages.Panels.Automatic;
using Smad.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Smad.Pages.Panels.Manual {

    public partial class ChecklistPanel : UserControl {

        public EventHandler UpdateData { get; set; }

        private readonly ReportPanel reportPanel;

        public ChecklistPanel(ReportPanel reportPanel) {
            InitializeComponent();

            Accordion.CheckBoxMargin = new Padding(10);
            Accordion.Insets = new Padding(10);
            Accordion.ControlBackColor = SystemColors.Control;

            Accordion.ContentMargin = new Padding(50);
            Accordion.ContentPadding = new Padding(0);

            this.reportPanel = reportPanel;
        }

        private void ChecklistPanel_Load(object sender, EventArgs e) {
            ///Definindo o grupo de itens.
            //Definindo os grupos disponíveis.
            string groupCurrent = "";
            foreach (var item in MasterPage.ObjectSerializeManager.Object.Items) {
                if (!item.Group.Equals(groupCurrent)) {
                    groupCurrent = item.Group;
                    GroupComboBox.Items.Add(item.Group);
                }
            }
            GroupComboBox.SelectedItem = MasterPage.ObjectSerializeManager.Object.Group;
            currentGroupBox = GroupComboBox.SelectedIndex;
            StartButton.Enabled = false;

            if (GroupComboBox.SelectedIndex != -1) {
                if (reportPanel.categoryFlags is null) {
                    StartDefineChecklist();
                } else {
                    DefineCheckList();
                }
            }

            Accordion.CategoryCheckedChanged += Category_CheckedChanged;
            Accordion.AnimateOpenEffect = AnimateWindowFlags.None;
            Accordion.AnimateCloseEffect = AnimateWindowFlags.None;
            Accordion.Insets = new Padding(10, 10, 10, 25);
            Accordion.CheckBoxMargin = new Padding(0);
            Accordion.ContentMargin = new Padding(50);
            Accordion.ContentPadding = new Padding(0);
        }

        private int currentGroupBox;
        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (currentGroupBox != GroupComboBox.SelectedIndex) {
                StartButton.Enabled = true;
            } else {
                StartButton.Enabled = false;
            }
        }
        private void StartButton_Click(object sender, EventArgs e) {
            currentGroupBox = GroupComboBox.SelectedIndex;
            StartButton.Enabled = false;

            StartDefineChecklist();
        }
        private void StartDefineChecklist() {
            ///Adicionando os novos itens na interface.
            //Obtendo os itens da técnica selecionada.
            var items = MasterPage.ObjectSerializeManager.Object.Items.Where(a => a.Group.Equals(GroupComboBox.SelectedItem));
            //Obtendo as categorias da técnica selecionada.
            int categories = 0;
            string categoryCurrent = "";
            foreach (var item in items) {
                if (!item.Category.Equals(categoryCurrent)) {
                    categoryCurrent = item.Category;
                    categories++;
                }
            }
            reportPanel.categoryFlags = new bool[categories];
            DefineCheckList();
        }

        private void Acc_CheckedChanged(object sender, EventArgs e) {
            var item = ((ItemError)sender).Item;

            foreach (var control in Accordion.Controls) {
                if (control.GetType().Equals(typeof(CheckBox)) && ((CheckBox)control).Text.Contains(item.Category)) {
                    //Atual informação de erro.
                    var index = MasterPage.ObjectSerializeManager.Object.Items.IndexOf(item);
                    if (MasterPage.ObjectSerializeManager.Object.Items[index].IsError == 1) {
                        MasterPage.ObjectSerializeManager.Object.Items[index].IsError = 0;
                    } else {
                        MasterPage.ObjectSerializeManager.Object.Items[index].IsError = 1;
                    }
                    MasterPage.ObjectSerializeManager.SaveObject();

                    //Calculando itens de defeito.
                    int maxSize = 0;
                    int onSize = 0;
                    int onDefect = 0;
                    var items = MasterPage.ObjectSerializeManager.Object.Items.Where(a => a.Group.Equals(item.Group) && a.Category.Equals(item.Category));
                    foreach (var sunItem in items) {
                        if (sunItem.IsError == 1) { onDefect++; }
                        if (sunItem.IsError != -1) { onSize++; }
                        maxSize++;
                    }

                    //Atualiza informação na interface.
                    if (onDefect > 1) {
                        ((CheckBox)control).Text = $"Categoria: {item.Category}          ({onSize} de {maxSize} itens verificados com {onDefect} defeitos identificados)";
                    } else {
                        ((CheckBox)control).Text = $"Categoria: {item.Category}          ({onSize} de {maxSize} itens verificados com {onDefect} defeito identificado)";
                    }
                    return;
                }
            }
        }
        private void Category_CheckedChanged(object sender, EventArgs e) {
            var category = ((CheckBox)sender).Text;

            int count = 0;
            foreach (var control in Accordion.Controls) {
                if (control.GetType().Equals(typeof(CheckBox))) {
                    if (((CheckBox)control).Text.Contains(category)) {
                        reportPanel.categoryFlags[count] = !reportPanel.categoryFlags[count];
                        break;
                    }
                    count++;
                }
            }
        }

        private void Notify(object sender, EventArgs e) {
            UpdateData?.Invoke(null, null);
        }

        private void DefineCheckList() {
            ///Limpar itens da interface.
            Accordion.Clear();

            ///Adicionando os novos itens na interface.
            //Obtendo os itens da técnica selecionada.
            var items = MasterPage.ObjectSerializeManager.Object.Items.Where(a => a.Group.Equals(GroupComboBox.SelectedItem));
            //Obtendo as categorias da técnica selecionada.
            var categories = new List<string>();
            string categoryCurrent = "";
            foreach (var item in items) {
                if (!item.Category.Equals(categoryCurrent)) {
                    categoryCurrent = item.Category;
                    categories.Add(item.Category);
                }
            }

            //Monstrando na tela as categorias.
            for (int i = 0; i < categories.Count; i++) {
                int maxSize = 0;
                int onSize = 0;
                int onDefect = 0;

                var subItems = items.Where(a => a.Category.Equals(categories[i]));
                var acc = new Accordion {
                    UpArrow = "É defeito? [x]sim [  ]não               ",
                    DownArrow = "É defeito? [  ]sim [x]não               ",
                    MidArrow = "É defeito? [  ]sim [  ]não               ",
                    CheckBoxMargin = new Padding(0),
                    Insets = new Padding(10, 0, 10, 15),
                    ControlBackColor = SystemColors.ControlLight,
                    ContentMargin = new Padding(50),
                    ContentPadding = new Padding(0),
                    AnimateOpenEffect = AnimateWindowFlags.None,
                    AnimateCloseEffect = AnimateWindowFlags.None
                };
                acc.CheckedChanged += Acc_CheckedChanged;
                foreach (var sunItem in subItems) {
                    if (sunItem.IsError == 1) { onDefect++; }
                    if (sunItem.IsError != -1) { onSize++; }
                    maxSize++;

                    acc.Add(new ItemError(sunItem) { UpdateData = Notify }, $"[{sunItem.Code}] {sunItem.Name}", sunItem.Name, 0, sunItem.IsError == 1, isMidArrow: sunItem.IsError == -1);
                }

                //Atualiza informação na interface.
                if (onDefect > 1) {
                    Accordion.Add(acc, $"Categoria: {categories[i]}          ({onSize} de {maxSize} itens verificados com {onDefect} defeitos identificados)", string.Empty, 0, reportPanel.categoryFlags[i]);
                } else {
                    Accordion.Add(acc, $"Categoria: {categories[i]}          ({onSize} de {maxSize} itens verificados com {onDefect} defeito identificado)", string.Empty, 0, reportPanel.categoryFlags[i]);
                }
            }

            //Savar nota técnica utilizada.
            MasterPage.ObjectSerializeManager.Object.Group = GroupComboBox.Text;
            MasterPage.ObjectSerializeManager.SaveObject();

            //Log.
            MasterPage.SetLog($"Seleção da técnica - {GroupComboBox.SelectedItem}");

            UpdateData?.Invoke(null, null);
        }
    }
}