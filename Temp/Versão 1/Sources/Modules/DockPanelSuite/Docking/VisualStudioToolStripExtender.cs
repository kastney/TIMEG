using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace LiveShowStudio.Modules.DockPanelSuite.Docking {

    [ProvideProperty("EnableVSStyle", typeof(ToolStrip))]
    public partial class ToolStripExtender : Component, IExtenderProvider {

        private readonly ThemeBase theme;
        private readonly Dictionary<ToolStrip, ToolStripProperties> strips = new Dictionary<ToolStrip, ToolStripProperties>();

        public ToolStripRenderer DefaultRenderer { get; set; }

        public ToolStripExtender(ThemeBase theme) {
            InitializeComponent();
            this.theme = theme;
        }

        public void SetStyle(ToolStrip strip) {
            ToolStripProperties properties;

            if (!strips.ContainsKey(strip)) {
                properties = new ToolStripProperties(strip);
                strips.Add(strip, properties);
            } else {
                _ = strips[strip];
            }

            if (theme == null) {
                if (DefaultRenderer != null) strip.Renderer = DefaultRenderer;
            } else {
                theme.ApplyTo(strip);
            }
        }
        public bool CanExtend(object extendee) {
            return extendee is ToolStrip;
        }

        private class ToolStripProperties {

            private readonly ToolStrip strip;
            private readonly Dictionary<ToolStripItem, string> menuText = new Dictionary<ToolStripItem, string>();

            public ToolStripProperties(ToolStrip toolstrip) {
                strip = toolstrip ?? throw new ArgumentNullException(nameof(toolstrip));
                if (strip is MenuStrip) SaveMenuStripText();
            }

            private void SaveMenuStripText() {
                foreach (ToolStripItem item in strip.Items) menuText.Add(item, item.Text);
            }
        }
    }
}