namespace LiveShowStudio.Modules.DockPanelSuite.LayoutManager {

    public interface ILayoutTheme {

        Docking.ThemeBase GetTheme(string persistTheme);
    }

    public interface ILayoutData {

        System.Collections.Generic.List<Layout> LoadAllDefaultLayouts();
        System.Collections.Generic.List<string> LoadAllUserLayouts();

        string LoadCurrentLayout();
        void SaveCurrentLayout(string content);

        string LoadDefaultLayout(string key);

        bool SaveUserLayout(string name, string xmlContent);
        bool RemoveUserLayout(string name);
        string LoadUserLayout(string name);

        Docking.IDockContent GetInstanceByPersistString(string persistString);
    }
}