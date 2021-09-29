using System.Drawing;
using LiveShowStudio.Modules.ObjectListView;
using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace Smad.Panels {

    public partial class FilterPanel : DockContent {

        public FilterPanel() => InitializeComponent();

        private void FilterPanel_Load(object sender, System.EventArgs e) {
            var textOverlay = ListView.EmptyListMsgOverlay as TextOverlay;
            textOverlay.Font = new Font("Microsoft Sans Serif", 8);
            textOverlay.BorderWidth = 0;
        }

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
            ListView.BackColor = colorPalette.Background;
            ListView.ForeColor = colorPalette.TextColor;
            ListView.UnfocusedSelectedBackColor = SystemColors.Highlight;
            ListView.UnfocusedSelectedForeColor = colorPalette.TextColor;

            var textOverlay = ListView.EmptyListMsgOverlay as TextOverlay;
            textOverlay.BackColor = colorPalette.Background;
        }
        public override void SetStyle(ToolStripExtender style) {
            style.SetStyle(ToolStrip);
        }

        public override void UpdateContent() {
            //Define o modo de exibição do painel de comentários.
            if (Pages.MainPage.ObjectSerializeManager is null || Pages.MainPage.ObjectSerializeManager.Object is null || Pages.MainPage.Index == -1) {
                Off();
            } else {
                On();
            }
        }
        private void On() {
            if (Pages.MainPage.Index < Pages.MainPage.ObjectSerializeManager.Object.Apps.Count) {
                /*Temporário
                Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Filters = new System.Collections.Generic.List<Entities.Filter> { new Entities.StatisticalSample() };
                Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].ProcessComments = new System.Collections.Generic.List<Entities.Comment>();
                //*/
                ListView.Objects = Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Filters;
            }
        }
        private void Off() {
            ListView.Objects = null;
        }

        private void ListView_ItemChecked(object sender, System.Windows.Forms.ItemCheckedEventArgs e) {
            var listItem = (OLVListItem)e.Item;
            //Percorre todos os filtros seguintes.
            for (int i = listItem.Index; i < Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Filters.Count; i++) {
                //Obtém o filtro.
                var filter = Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Filters[i];
                if (filter.IsEnabled) {
                    filter.Apply(Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index]);
                } else {
                    filter.Unapply(Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index]);
                }
            }

            //Registra mudança após mudar o status de ativação de um filtro.
            Pages.MainPage.ObjectSerializeManager.RegisterChanged();
        }

        private void ListView_SelectionChanged(object sender, System.EventArgs e) {
            if (ListView.SelectedIndex != -1) {

                if (Pages.MainPage.LayoutManager.GetPanelByType<PropertiesPanel>() is PropertiesPanel propertiesPanel) {
                    propertiesPanel.PropertyGrid.SelectedObject = Pages.MainPage.ObjectSerializeManager.Object.Apps[Pages.MainPage.Index].Filters[ListView.SelectedIndex];
                    propertiesPanel.UpdateContent();
                }

                ListView.SelectedIndex = -1;
            }
        }
    }
}