using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace LiveShowStudio.Modules.DockPanelSuite.Themes.Default {

    internal class DefaultAutoHideWindowFactory : DockPanelExtender.IAutoHideWindowFactory {

        public DockPanel.AutoHideWindowControl CreateAutoHideWindow(DockPanel panel) {
            return new DefaultAutoHideWindowControl(panel);
        }
    }
}