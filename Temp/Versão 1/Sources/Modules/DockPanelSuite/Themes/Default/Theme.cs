namespace LiveShowStudio.Modules.DockPanelSuite.Themes.Default {

    using Docking;

    public abstract class Theme : ThemeBase {

        public Theme(byte[] resources) {
            ColorPalette = new DockPanelColorPalette(new DefaultPaletteFactory(resources));
            Skin = new DockPanelSkin();
            PaintingService = new PaintingService();
            ImageService = new ImageService(this);
            ToolStripRenderer = new VisualStudioToolStripRenderer(ColorPalette) {
                UseGlassOnMenuStrip = false,
            };
            Measures.SplitterSize = 6;
            Measures.AutoHideSplitterSize = 3;
            Measures.DockPadding = 6;
            ShowAutoHideContentOnHover = false;
            Extender.AutoHideStripFactory = new DefaultAutoHideStripFactory();
            Extender.AutoHideWindowFactory = new DefaultAutoHideWindowFactory();
            Extender.DockPaneFactory = new DefaultDockPaneFactory();
            Extender.DockPaneCaptionFactory = new DefaultDockPaneCaptionFactory();
            Extender.DockPaneStripFactory = new DefaultDockPaneStripFactory();
            Extender.DockPaneSplitterControlFactory = new DefaultDockPaneSplitterControlFactory();
            Extender.WindowSplitterControlFactory = new DefaultWindowSplitterControlFactory();
            Extender.DockWindowFactory = new DefaultDockWindowFactory();
            Extender.PaneIndicatorFactory = new DefaultPaneIndicatorFactory();
            Extender.PanelIndicatorFactory = new DefaultPanelIndicatorFactory();
            Extender.DockOutlineFactory = new DefaultDockOutlineFactory();
            Extender.DockIndicatorFactory = new DefaultDockIndicatorFactory();
        }

        public override void CleanUp(DockPanel dockPanel) {
            PaintingService.CleanUp();
            base.CleanUp(dockPanel);
        }
    }
}