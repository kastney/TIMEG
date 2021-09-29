using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace LiveShowStudio.Modules.DockPanelSuite.Themes.Default {

    internal class DefaultDockPaneCaptionFactory : DockPanelExtender.IDockPaneCaptionFactory {

        public DockPaneCaptionBase CreateDockPaneCaption(DockPane pane) {
            return new DefaultDockPaneCaption(pane);
        }
    }
}