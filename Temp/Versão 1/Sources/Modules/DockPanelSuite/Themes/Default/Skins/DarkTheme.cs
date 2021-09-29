namespace LiveShowStudio.Modules.DockPanelSuite.Docking {

    using Themes.Default;

    public class DarkTheme : Theme {

        public DarkTheme() : base(Decompress(Resources.default_dark_theme)) {
            DockContentColorPalette = new DockContentColorPalette {
                Background = System.Drawing.Color.FromArgb(37, 37, 37),
                TextColor = System.Drawing.Color.White,
                Control = ColorPalette.CommandBarMenuDefault.Background
            };
        }
    }
}