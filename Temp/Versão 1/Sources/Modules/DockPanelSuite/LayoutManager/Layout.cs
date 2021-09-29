namespace LiveShowStudio.Modules.DockPanelSuite.LayoutManager {

    public class Layout {

        public string Name { get; private set; }
        public string Key { get; private set; }

        public Layout(string name) {
            Name = name;
            Key = null;
        }
        public Layout(string name, string key) : this(name) {
            Key = key;
        }
    }
}