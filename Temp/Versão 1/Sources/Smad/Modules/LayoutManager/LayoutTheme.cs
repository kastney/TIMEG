using LiveShowStudio.Modules.DockPanelSuite.Docking;
using LiveShowStudio.Modules.DockPanelSuite.LayoutManager;

namespace Smad.Modules.LayoutManager {
    
    public class LayoutTheme : ILayoutTheme {

        public ThemeBase GetTheme(string persistTheme) {
            if (Properties.Settings.Default.Theme.Equals(persistTheme)) return null;
            if (persistTheme is null) persistTheme = Properties.Settings.Default.Theme;

            if (persistTheme.Equals("Light")) {
                Properties.Settings.Default.Theme = "Light";
                Properties.Settings.Default.Save();
                return new LightTheme();
            } else {
                Properties.Settings.Default.Theme = "Dark";
                Properties.Settings.Default.Save();
                return new DarkTheme();
            }
        }
    }
}
