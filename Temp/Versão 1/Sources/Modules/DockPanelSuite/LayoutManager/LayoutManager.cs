using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using LiveShowStudio.Modules.DockPanelSuite.Docking;

namespace LiveShowStudio.Modules.DockPanelSuite.LayoutManager {

    public class LayoutManager<LayoutTheme, LayoutData> where LayoutTheme : ILayoutTheme where LayoutData : ILayoutData {

        #region Initialization
        private readonly DockPanel dock;
        private readonly ILayoutData layoutData;
        private readonly ILayoutTheme layoutTheme;

        public LayoutManager(DockPanel dock) {
            this.dock = dock;
            layoutTheme = Activator.CreateInstance<LayoutTheme>();
            layoutData = Activator.CreateInstance<LayoutData>();
        }
        public void Init() {
            SetTheme(null);

            var layout = layoutData.LoadCurrentLayout();
            if (!string.IsNullOrEmpty(layout)) {
                SetLayout(layout);
            } else if (defaultLayouts != null && defaultLayouts.Count != 0) {
                SetLayout(layoutData.LoadDefaultLayout(defaultLayouts[0].Key));
            }
        }
        #endregion

        #region Theme Manager
        public delegate void ThemeHandler(ToolStripExtender style);
        public ThemeHandler SetStyle { get; set; }

        public void SetTheme(string nameTheme) {
            if (layoutTheme.GetTheme(nameTheme) is ThemeBase theme) {
                if (nameTheme is null) {
                    dock.Theme = theme;
                    SetStyle?.Invoke(new ToolStripExtender(theme));
                } else {
                    var xmlContent = dock.GenerateXml();

                    while (dock.Contents.Count != 0) {
                        var content = (DockContent)dock.Contents[0];
                        content.DockPanel = null;
                        dockContents.Add(content);
                    }
                    foreach (var window in dock.FloatWindows.ToList()) window.Dispose();

                    dock.Theme = theme;
                    SetStyle?.Invoke(new ToolStripExtender(theme));
                    if (currentPage != null) currentPage.SetColors(theme.DockContentColorPalette);

                    dock.LoadFromXml(xmlContent, GetInstanceByPersistString);
                }
            }
        }
        public ThemeBase GetTheme() {
            return dock.Theme;
        }
        #endregion

        #region Options Manager
        private ToolStripDropDownButton dropDown;
        private ToolStripMenuItem itemNewLayout;
        private ToolStripMenuItem itemRemoveLayout;

        public ToolStripDropDownButton DropDown {
            get { return dropDown; }
            set {
                dropDown = value;

                defaultLayouts = layoutData.LoadAllDefaultLayouts();
                userLayouts = layoutData.LoadAllUserLayouts();
                dockContents = new List<IDockContent>();

                itemNewLayout = new ToolStripMenuItem("Novo layout...");
                itemNewLayout.Click += ItemNewLayout_Click;
                itemRemoveLayout = new ToolStripMenuItem("Apagar layout...");
                itemRemoveLayout.Click += ItemRemoveLayout_Click;

                dropDown.DropDownOpening += DropDown_DropDownOpening;
            }
        }

        private void DropDown_DropDownOpening(object sender, EventArgs e) {
            var dropDown = DropDownClear((ToolStripDropDownButton)sender);

            if (userLayouts.Count != 0) {
                for (int i = userLayouts.Count - 1; i > -1; i--) {
                    var item = new ToolStripMenuItem(userLayouts[i]);
                    item.Click += SelectedItem_Click;
                    dropDown.DropDownItems.Add(item);
                }
                dropDown.DropDownItems.Add(new ToolStripSeparator());
            }

            if (defaultLayouts.Count != 0) {
                foreach (var layout in defaultLayouts) {
                    var item = new ToolStripMenuItem(layout.Name) { Tag = layout };
                    item.Click += SelectedItem_Click;
                    dropDown.DropDownItems.Add(item);
                }
                dropDown.DropDownItems.Add(new ToolStripSeparator());
            }

            dropDown.DropDownItems.Add(itemNewLayout);
            if (userLayouts.Count != 0) dropDown.DropDownItems.Add(itemRemoveLayout);
        }
        private ToolStripDropDownButton DropDownClear(ToolStripDropDownButton dropDown) {
            for (int i = 0; i < dropDown.DropDownItems.Count - 3; i++) if (dropDown.DropDownItems[i] is ToolStripMenuItem) dropDown.DropDownItems[i].Click -= SelectedItem_Click;
            dropDown.DropDownItems.Clear();
            return dropDown;
        }
        #endregion

        #region Layout Manager
        private List<string> userLayouts;
        private List<Layout> defaultLayouts;
        private List<IDockContent> dockContents;

        private void SelectedItem_Click(object sender, EventArgs e) {
            var item = (ToolStripMenuItem)sender;
            var content = item.Tag is Layout layout ? layoutData.LoadDefaultLayout(layout.Key) : layoutData.LoadUserLayout(item.Text);
            if (!string.IsNullOrEmpty(content)) SetLayout(content);
        }
        private void ItemNewLayout_Click(object sender, EventArgs e) {
            using (var dialog = new NewLayoutDialog(userLayouts, defaultLayouts)) {
                if (dialog.ShowDialog() == DialogResult.OK && layoutData.SaveUserLayout(dialog.LayoutName, dock.GenerateXml())) {
                    userLayouts.Add(dialog.LayoutName);
                }
            }
        }
        private void ItemRemoveLayout_Click(object sender, EventArgs e) {
            using (var dialog = new RemoveLayoutDialog(userLayouts)) {
                if (dialog.ShowDialog() == DialogResult.OK && layoutData.RemoveUserLayout(userLayouts[dialog.IndexLayout])) {
                    userLayouts.RemoveAt(dialog.IndexLayout);
                }
            }
        }

        private void SetLayout(string xmlContent) {
            while (dock.Contents.Count != 0) {
                var content = (DockContent)dock.Contents[0];
                content.DockPanel = null;
                dockContents.Add(content);
            }

            dock.LoadFromXml(xmlContent, GetInstanceByPersistString);

            while (dockContents.Count != 0) {
                ((DockContent)dockContents[0]).Close();
                dockContents.RemoveAt(0);
            }
        }
        public IDockContent GetInstanceByPersistString(string persistString) {
            for (int i = 0; i < dockContents.Count; i++) {
                var content = dockContents[i];
                if (content.GetType().FullName.Equals(persistString)) {
                    dockContents.RemoveAt(i);
                    return content;
                }
            }

            var panel = layoutData.GetInstanceByPersistString(persistString);
            panel.UpdateContent();
            return panel;
        }

        public void UpdateLayout() {
            foreach (var panel in dock.Contents) {
                panel.UpdateContent();
            }
        }
        #endregion

        #region Panels Manager
        private DockContent currentPage;
        public void OpenPage<T>() where T : DockContent {
            using (var page = Activator.CreateInstance<T>()) {
                page.SetColors(dock.Theme.DockContentColorPalette);
                currentPage = page;
                page.ShowDialog();
            }
        }
        public T OpenDialog<T>() where T : DockContent {
            var dialog = Activator.CreateInstance<T>();
            dialog.SetColors(dock.Theme.DockContentColorPalette);
            return dialog;
        }
        public T OpenPanel<T>() where T : DockContent {
            if (GetPanelByType<T>() is T panel) {
                panel.Activate();
                panel.UpdateContent();
            } else {
                panel = Activator.CreateInstance<T>();
                panel.SetColors(dock.Theme.DockContentColorPalette);
                panel.SetStyle(new ToolStripExtender(dock.Theme));
                panel.UpdateContent();
                panel.Show(dock);
            }

            return panel;
        }

        public DockContent GetPanelByType<T>() where T : DockContent {
            foreach (DockContent content in dock.Contents) {
                if (content.Name.Equals(typeof(T).Name)) {
                    return content;
                }
            }
            return null;
        }
        #endregion

        public void Dispose() {
            layoutData.SaveCurrentLayout(dock.GenerateXml());
            GC.SuppressFinalize(this);
        }
    }
}