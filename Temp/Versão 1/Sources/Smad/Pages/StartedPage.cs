using System.Windows.Forms;
using Smad.UserControls.Started;
using Smad.Modules.LayoutManager;
using LiveShowStudio.Modules.DockPanelSuite.Docking;
using LiveShowStudio.Modules.DockPanelSuite.LayoutManager;
using System.Collections.Generic;
using LiveShowStudio.Modules.ObjectSerializeManager;
using Smad.Entities;
using Smad.Modules.ObjectSerialize;
using Smad.Panels;

namespace Smad.Pages {

    public partial class StartedPage : DockContent {

        private readonly List<Control> controls;

        private LayoutManager<LayoutTheme, LayoutData> layoutManager;
        private ObjectSerializeManager<Experiment, ObjectData> objectSerializeManager;

        public StartedPage(LayoutManager<LayoutTheme, LayoutData> layoutManager, ObjectSerializeManager<Experiment, ObjectData> objectSerializeManager) {
            InitializeComponent();
            controls = new List<Control>();
            this.layoutManager = layoutManager;
            this.objectSerializeManager = objectSerializeManager;
        }

        private void StartedPage_Load(object sender, System.EventArgs e) {
            ///Opções
            var options = new List<UserOption> {
                new UserOption { Name = "Novo Projeto", Content = new ProjetTypeStarted { InstantiateHandler = Instantiate, NextHandler = Next, BackHandler = Back } },
                new UserOption { Name = "Abrir Recentes", Content = new RecentStarted(objectSerializeManager) { InstantiateHandler = Instantiate } },
                new UserOption { Name = "Abrir Projeto" }
            };
            ListView.Objects = options;

            ListView.SelectedIndex = objectSerializeManager.GetRecentObject().Count == 0 ? 0 : 1;
            controls.Add(options[0].Content);
            ListView_Click(null, null);
        }

        public override void SetColors(DockContentColorPalette colorPalette) {
            ///Gerenciador do Tema
            BackColor = colorPalette.Background;
            ListView.ForeColor = colorPalette.TextColor;
            ListView.BackColor = colorPalette.Control;
            ListView.UnfocusedSelectedForeColor = colorPalette.TextColor;
            ListView.UnfocusedSelectedBackColor = System.Drawing.SystemColors.Highlight;
        }

        private int currentIndex = -1;
        private void ListView_SelectionChanged(object sender, System.EventArgs e) {
            if (ListView.SelectedIndex == -1) {
                ListView.SelectedIndex = currentIndex;
            }

            currentIndex = ListView.SelectedIndex;
        }
        private void ListView_Click(object sender, System.EventArgs e) {
            if (ListView.SelectedIndex != -1 && currentIndex != ListView.SelectedIndex) {
                //Adicionando novo controle na lanela
                var option = ListView.SelectedObject as UserOption;
                if (option.Content != null) {
                    //Limpando a janela principal
                    ContentPanel.Controls.Clear();

                    if (ListView.SelectedObject != null && ((UserOption)ListView.SelectedObject).Content is ProjetTypeStarted) {
                        var content = controls[controls.Count - 1];
                        content.Dock = DockStyle.Fill;
                        ContentPanel.Controls.Add(content);
                    } else {
                        var content = option.Content;
                        content.Dock = DockStyle.Fill;
                        ContentPanel.Controls.Add(content);
                    }

                    //Atualizando a interface
                    option.Content.SetColors(layoutManager.GetTheme().DockContentColorPalette);
                    option.Content.UpdateContent();
                } else {
                    ListView.SelectedIndex = currentIndex;

                    objectSerializeManager.CloseObject();
                    objectSerializeManager.OpenObject(null);
                    if (objectSerializeManager.Object != null) {
                        Instantiate(objectSerializeManager.Object);
                    }
                }
            }
        }

        BrowserPreviewPanel browserPreview;
        private void Instantiate(object value) {
            var experiment = value as Experiment;

            objectSerializeManager.NewObject(experiment);
            ///Salva o projeto se não for salvo
            if (!experiment.IsSaved) { objectSerializeManager.SaveObject(); }

            if (experiment.Apps.Count != 0) {
                ///Baixa os comentários
                if (experiment.Apps[0].Comments.Count == 0) {
                    MessageBox.Show("Será necessário baixar os comentários desse aplicativo.\nEsse processo pode demorar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    using (browserPreview = new BrowserPreviewPanel()) {
                        browserPreview.SetColors(layoutManager.GetTheme().DockContentColorPalette);
                        browserPreview.FinishHandler = Finish;
                        browserPreview.GetComments(experiment.Apps[0].Id);
                        browserPreview.ShowDialog();
                    }
                } else {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            } else {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void Finish(List<Comment> comments) {
            browserPreview.Close();

            objectSerializeManager.Object.Apps[0].Comments = comments;
            objectSerializeManager.SaveObject();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Next(Control control) {
            controls.Add(control);
            ((BaseStarted)control).SetColors(layoutManager.GetTheme().DockContentColorPalette);
            ((BaseStarted)control).UpdateContent();

            ContentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(control);
        }
        private void Back() {
            controls.RemoveAt(controls.Count - 1);

            ContentPanel.Controls.Clear();
            var content = controls[controls.Count - 1];
            content.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(content);
        }
    }

    class UserOption {
        public string Name { get; set; }
        public BaseStarted Content { get; set; }
    }
}