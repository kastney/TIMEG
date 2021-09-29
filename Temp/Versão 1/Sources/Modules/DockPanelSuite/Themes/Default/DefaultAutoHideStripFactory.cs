using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace LiveShowStudio.Modules.DockPanelSuite.Themes.Default {

    internal class DefaultAutoHideStripFactory : DockPanelExtender.IAutoHideStripFactory {

        public AutoHideStripBase CreateAutoHideStrip(DockPanel panel) {
            return new DefaultAutoHideStrip(panel);
        }
    }
}