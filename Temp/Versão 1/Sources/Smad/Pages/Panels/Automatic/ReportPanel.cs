using System;
using Smad.Dialogs;
using System.Windows.Forms;

namespace Smad.Pages.Panels.Automatic {

    public partial class ReportPanel : UserControl {

        public bool[] categoryFlags;

        private Timer timer;
        public DateTime Stopwatch { get; set; }
        private DateTime limit;

        public ReportPanel() {
            InitializeComponent();
            timer = new Timer { Interval = 1000 };
            timer.Tick += Timer_Tick;
        }
        private void ReportPanel_Load(object sender, EventArgs e) {
            var experiment = MasterPage.ObjectSerializeManager.Object;

            if (experiment.IsManual) {
                CardViewList.AddCard(new UserControls.Card(175, 175) {
                    Title = "Checklist de inspeção",
                    Color = System.Drawing.Color.DarkCyan,
                    Icon = Properties.Resources.icon_checklist
                });
                //CardViewList.AddCard(new UserControls.Card(175, 175) {
                //    Title = "Checklist de inspeção",
                //    Color = System.Drawing.Color.DarkCyan,
                //    Icon = Properties.Resources.icon_checklist
                //});
                CardViewList.AddCard(new UserControls.Card(175, 175) {
                    Title = "Relatório de erros",
                    Color = System.Drawing.Color.DarkKhaki,
                    Icon = Properties.Resources.icon_report
                });
                CardViewList.AddCard(new UserControls.Card(175, 175) {
                    Title = "Nuvem de palavras",
                    Color = System.Drawing.Color.DarkGoldenrod,
                    Icon = Properties.Resources.icon_word_cloud
                });
                CardViewList.AddCard(new UserControls.Card(175, 175) {
                    Title = "Lista de comentários",
                    Color = System.Drawing.Color.DarkCyan,
                    Icon = Properties.Resources.icon_comments
                });
                CardViewList.AddCard(new UserControls.Card(175, 175) {
                    Title = "Fechar projeto",
                    Color = System.Drawing.Color.DarkRed,
                    Icon = Properties.Resources.icon_exit
                });
            } else {
                CardViewList.AddCard(new UserControls.Card(175, 175) {
                    Title = "Informações gerais",
                    Color = System.Drawing.Color.DarkMagenta,
                    Icon = Properties.Resources.icon_general_infor
                });
                CardViewList.AddCard(new UserControls.Card(175, 175) {
                    Title = "Lista de comentários",
                    Color = System.Drawing.Color.DarkCyan,
                    Icon = Properties.Resources.icon_comments
                });
                CardViewList.AddCard(new UserControls.Card(175, 175) {
                    Title = "Nuvem de palavras",
                    Color = System.Drawing.Color.DarkGoldenrod,
                    Icon = Properties.Resources.icon_word_cloud
                });
                CardViewList.AddCard(new UserControls.Card(175, 175) {
                    Title = "Fechar projeto",
                    Color = System.Drawing.Color.DarkRed,
                    Icon = Properties.Resources.icon_exit
                });
            }

            Stopwatch = MasterPage.ObjectSerializeManager.Object.Stopwatch;
            CardViewList.SelectedChanged += CardViewList_SelectedChanged;
            CardViewList.IsUnselected = false;
        }

        private void CardViewList_SelectedChanged(object sender, EventArgs e) {
            timer.Stop();
            if (CardViewList.SelectedCard.Title == "Informações gerais") {
                ContentPanel.Controls.Clear();
                var panel = new DefaultInforPanel {
                    Dock = DockStyle.Fill
                };
                ContentPanel.Controls.Add(panel);
            } else if (CardViewList.SelectedCard.Title == "Lista de comentários") {
                var experiment = MasterPage.ObjectSerializeManager.Object;
                if (experiment.Apps.Count != 0) {
                    ContentPanel.Controls.Clear();
                    var panel = new CommentsPanel {
                        Dock = DockStyle.Fill
                    };
                    ContentPanel.Controls.Add(panel);
                } else {
                    using (var page = new IdApplicationDialog()) {
                        if (page.ShowDialog() == DialogResult.OK) {
                            MasterPage.ObjectSerializeManager.Object.Apps.Add(page.App);
                            MasterPage.ObjectSerializeManager.Object.Apps[0].Comments = page.Comments;
                            MasterPage.ObjectSerializeManager.SaveObject();

                            ContentPanel.Controls.Clear();
                            var panel = new WordCloudPanel {
                                Dock = DockStyle.Fill
                            };
                            ContentPanel.Controls.Add(panel);
                        }
                    }
                }
                MasterPage.SetLog("\nPainel aberto - Lista de comentários");
            } else if (CardViewList.SelectedCard.Title == "Nuvem de palavras") {
                var experiment = MasterPage.ObjectSerializeManager.Object;
                if (experiment.Apps.Count != 0) {
                    ContentPanel.Controls.Clear();
                    var panel = new WordCloudPanel {
                        Dock = DockStyle.Fill
                    };
                    ContentPanel.Controls.Add(panel);
                } else {
                    using (var page = new IdApplicationDialog()) {
                        if (page.ShowDialog() == DialogResult.OK) {
                            MasterPage.ObjectSerializeManager.Object.Apps.Add(page.App);
                            MasterPage.ObjectSerializeManager.Object.Apps[0].Comments = page.Comments;
                            MasterPage.ObjectSerializeManager.SaveObject();

                            ContentPanel.Controls.Clear();
                            var panel = new WordCloudPanel {
                                Dock = DockStyle.Fill
                            };
                            ContentPanel.Controls.Add(panel);
                        }
                    }
                }
                MasterPage.SetLog("\nPainel aberto - Nuvem de palavras");
            } else if (CardViewList.SelectedCard.Title == "Informações temporais") {
                ContentPanel.Controls.Clear();
                var panel = new TimePanel {
                    Dock = DockStyle.Fill
                };
                ContentPanel.Controls.Add(panel);
            } else if (CardViewList.SelectedCard.Title == "Checklist de inspeção 2") {
                //Começa a contar o tempo.
                timer.Start();
                limit = new DateTime(1, 1, 1, 0, 5, 0);
                //Mostra o conteúdo na tela
                ContentPanel.Controls.Clear();
                var panel = new ChecklistPanel {
                    Dock = DockStyle.Fill,
                    UpdateData = UpdateData
                };
                ContentPanel.Controls.Add(panel);
                //Define o log.
                MasterPage.SetLog("\nPainel aberto - Checklist de inspeção");
            } else if (CardViewList.SelectedCard.Title == "Checklist de inspeção") {
                //Começa a contar o tempo.
                timer.Start();
                limit = new DateTime(1, 1, 1, 0, 5, 0);
                //Mostra o conteúdo na tela
                ContentPanel.Controls.Clear();
                var panel = new Manual.ChecklistPanel(this) {
                    Dock = DockStyle.Fill,
                    UpdateData = UpdateData
                };
                ContentPanel.Controls.Add(panel);
                //Define o log.
                MasterPage.SetLog("\nPainel aberto - Checklist de inspeção");
            } else if (CardViewList.SelectedCard.Title == "Relatório de erros") {
                if (!string.IsNullOrEmpty(MasterPage.ObjectSerializeManager.Object.Group)) {
                    ContentPanel.Controls.Clear();
                    var panel = new Manual.PrintViewPanel {
                        Dock = DockStyle.Fill
                    };
                    ContentPanel.Controls.Add(panel);
                } else {
                    MessageBox.Show("Selecione um checklist antes de gerar um relatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CardViewList.SelectedIndex();
                }
                MasterPage.SetLog("\nPainel aberto - Relatório de erros");
            } else if (CardViewList.SelectedCard.Title == "Fechar projeto") {
                if (MessageBox.Show("Você quer fechar este projeto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                    Application.Restart();
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e) {
            if (limit == DateTime.MinValue) {
                timer.Stop();
                return;
            }

            Stopwatch = Stopwatch.AddSeconds(1);
            limit = limit.AddSeconds(-1);
            Console.WriteLine($"{Stopwatch} - {limit}");
        }
        private void UpdateData(object sender, EventArgs e) {
            limit = new DateTime(1, 1, 1, 0, 5, 0);
            timer.Start();

            //Salvando tempo de uso.
            MasterPage.ObjectSerializeManager.Object.Stopwatch = Stopwatch;
            MasterPage.ObjectSerializeManager.SaveObject();
        }
    }
}