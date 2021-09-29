using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace Smad.UserControls.Started {

    public partial class ProjetTypeStarted : BaseStarted {

        private DockContentColorPalette colorPalette;

        public ProjetTypeStarted() => InitializeComponent();
        private void ProjetTypeStarted_Load(object sender, System.EventArgs e) {
            //CardViewList.AddCard(new Card {
            //    Title = "Nova Avaliação Automática",
            //    Color = System.Drawing.Color.DarkCyan,
            //    Icon = Properties.Resources.icon_robot_evaluation
            //});
            CardViewList.AddCard(new Card {
                Title = "Nova Avaliação Manual",
                Color = System.Drawing.Color.DarkOrange,
                Icon = Properties.Resources.icon_robot_evaluation
            });

            CardViewList.SelectedChanged += CardViewList_SelectedChanged;
            CardViewList.CardDobleClick += NextButton_Click;
        }

        public override void SetColors(DockContentColorPalette colorPalette) {
            this.colorPalette = colorPalette;

            TitleLabel.ForeColor = colorPalette.TextColor;
            NextButton.BackColor = colorPalette.Control;
            NextButton.ForeColor = colorPalette.TextColor;
        }

        private void CardViewList_SelectedChanged(object sender, System.EventArgs e) {
            if (CardViewList.SelectedCard is null) {
                NextButton.Enabled = false;
            } else {
                NextButton.Enabled = true;
            }
        }

        private void NextButton_Click(object sender, System.EventArgs e) {
            if (CardViewList.SelectedCard != null) {
                ///Nova avaliação automática
                if (CardViewList.SelectedCard.Title.Equals("Nova Avaliação Automática")) {
                    NextHandler?.Invoke(new NewAppStarted { BackHandler = BackHandler, InstantiateHandler = InstantiateHandler });
                }

                ///Nova avaliação manual
                if (CardViewList.SelectedCard.Title.Equals("Nova Avaliação Manual")) {
                    NextHandler?.Invoke(new NewManualStarted { BackHandler = BackHandler, InstantiateHandler = InstantiateHandler });
                }
            }
        }

        public override void UpdateContent() {
            CardViewList_SelectedChanged(null, null);
        }
    }
}