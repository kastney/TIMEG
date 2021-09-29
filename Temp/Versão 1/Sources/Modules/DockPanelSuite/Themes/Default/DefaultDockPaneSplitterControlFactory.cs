using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace LiveShowStudio.Modules.DockPanelSuite.Themes.Default {

    internal class DefaultDockPaneSplitterControlFactory : DockPanelExtender.IDockPaneSplitterControlFactory {

        public DockPane.SplitterControlBase CreateSplitterControl(DockPane pane) {
            return new DefaultSplitterControl(pane);
        }
    }
}