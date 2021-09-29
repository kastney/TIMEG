using System.Drawing;

namespace LiveShowStudio.Modules.DockPanelSuite.Docking {

    public static class LayoutUtils {

        public static bool IsZeroWidthOrHeight(Rectangle rectangle) {
            return (rectangle.Width == 0 || rectangle.Height == 0);
        }
    }
}