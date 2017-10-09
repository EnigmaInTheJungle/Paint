using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Paint.Data;
using Paint.UI.Panels;
using Paint.UI.Managers;
using Paint.Plugins.Manager;
using Paint.Plugins;

namespace Paint.UI.Tabs.Page
{
    public class Page : TabPage
    {
        private static int _count = 0;

        ViewPanel _viewPanel;

        public IPluginState PageState => _viewPanel.State;
        public IPlugin PagePlugin => _viewPanel.Plugin;

        public void SetPagePlugin(IPluginState state, IPlugin plugin)
        {
            _viewPanel.State = state;
            _viewPanel.Plugin = plugin;
        }

        public Page(string pageText)
        {
            Dock = DockStyle.Fill;

            Text = pageText + ((pageText == "Page") ? _count++.ToString() : "");
            Name = Text;

            _viewPanel = new ViewPanel();
            Controls.Add(_viewPanel);
        }

    }
}
