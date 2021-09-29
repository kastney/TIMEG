using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace LiveShowStudio.Modules.DockPanelSuite.Themes.Default {

    internal class DefaultWindowSplitterControlFactory : DockPanelExtender.IWindowSplitterControlFactory {

        public SplitterBase CreateSplitterControl(ISplitterHost host) {
            return new DefaultWindowSplitterControl(host);
        }
    }
}