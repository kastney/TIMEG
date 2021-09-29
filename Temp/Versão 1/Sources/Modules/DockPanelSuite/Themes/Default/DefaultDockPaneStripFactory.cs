using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace LiveShowStudio.Modules.DockPanelSuite.Themes.Default {

    public class DefaultDockPaneStripFactory : DockPanelExtender.IDockPaneStripFactory {

        public DockPaneStripBase CreateDockPaneStrip(DockPane pane) {
            return new DefaultDockPaneStrip(pane);
        }
    }
}