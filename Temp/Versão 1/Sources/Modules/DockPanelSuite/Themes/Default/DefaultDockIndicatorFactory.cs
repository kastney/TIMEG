using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace LiveShowStudio.Modules.DockPanelSuite.Themes.Default {

    internal class DefaultDockIndicatorFactory : DockPanelExtender.IDockIndicatorFactory {

        public DockPanel.DockDragHandler.DockIndicator CreateDockIndicator(DockPanel.DockDragHandler dockDragHandler) {
            return new DockPanel.DockDragHandler.DockIndicator(dockDragHandler) { Opacity = 0.7 };
        }
    }
}