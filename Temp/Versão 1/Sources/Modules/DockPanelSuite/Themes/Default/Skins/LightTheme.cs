namespace LiveShowStudio.Modules.DockPanelSuite.Docking {

    using Themes.Default;

    public class LightTheme : Theme {

        public LightTheme() : base(Decompress(Resources.default_light_theme)) {
            DockContentColorPalette = new DockContentColorPalette {
                Background = System.Drawing.Color.White,
                TextColor = System.Drawing.Color.Black,
                Control = ColorPalette.CommandBarMenuDefault.Background
            };
        }
    }
}