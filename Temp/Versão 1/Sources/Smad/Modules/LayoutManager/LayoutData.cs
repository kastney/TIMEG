using System;
using System.Collections.Generic;
using LiveShowStudio.Modules.DockPanelSuite.Docking;
using LiveShowStudio.Modules.DockPanelSuite.LayoutManager;

namespace Smad.Modules.LayoutManager {

    public class LayoutData : ILayoutData {

        //Gerenciamento do layout atual do usuário
        public string LoadCurrentLayout() {
            return Properties.Settings.Default.Layout;
        }
        public void SaveCurrentLayout(string content) {
            Properties.Settings.Default.Layout = content;
            Properties.Settings.Default.Save();
        }

        //Gerenciamento dos layouts padrões do software
        public List<Layout> LoadAllDefaultLayouts() {
            return new List<Layout> {
                //new Layout("Editor de cenas", "SceneEditorLayout")
            };
        }
        public string LoadDefaultLayout(string key) {
            switch (key) {
                default: return DefaultLayouts.SceneEditorLayout;
            }
        }

        //Gerenciamento dos layouts do usuário
        public List<string> LoadAllUserLayouts() {
            List<UserLayout> userLayouts = Properties.Settings.Default.UserLayouts;
            if (userLayouts == null) {
                userLayouts = new List<UserLayout>();
                Properties.Settings.Default.UserLayouts = userLayouts;
                Properties.Settings.Default.Save();
            }

            List<string> layouts = new List<string>();
            foreach (UserLayout layout in userLayouts) {
                layouts.Add(layout.Name);
            }

            return layouts;
        }
        public string LoadUserLayout(string name) {
            List<UserLayout> userLayouts = Properties.Settings.Default.UserLayouts;
            foreach (UserLayout layout in userLayouts) {
                if (layout.Name.Equals(name)) {
                    return layout.Content;
                }
            }

            return null;
        }
        public bool SaveUserLayout(string name, string xmlContent) {
            List<UserLayout> userLayouts = Properties.Settings.Default.UserLayouts;
            userLayouts.Add(new UserLayout { Name = name, Content = xmlContent });
            Properties.Settings.Default.UserLayouts = userLayouts;
            Properties.Settings.Default.Save();
            return true;
        }
        public bool RemoveUserLayout(string name) {
            List<UserLayout> userLayouts = Properties.Settings.Default.UserLayouts;

            foreach (UserLayout layout in userLayouts) {
                if (layout.Name.Equals(name)) {
                    userLayouts.Remove(layout);
                    Properties.Settings.Default.UserLayouts = userLayouts;
                    Properties.Settings.Default.Save();
                    return true;
                }
            }

            return false;
        }

        //Carregamento de instâncias de paineis
        public IDockContent GetInstanceByPersistString(string persistString) {
            return Activator.CreateInstance(Type.GetType(persistString)) as IDockContent;
        }
    }
}