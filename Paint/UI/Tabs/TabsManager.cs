using Paint.Command;
using Paint.Data;
using Paint.Plugins;
using Paint.Plugins.Manager;
using Paint.UI.Tabs.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.Managers
{
    public static class TabsManager
    {
        private static Tabs.Tabs _tabs;

        private const string _defaultName = "Page";
        public static IPlugin PagePlugin => _tabs.ActivePage.PagePlugin;
        public static IPluginState PageState => _tabs.ActivePage.PageState;


        public static void SetTabs(Tabs.Tabs tabs)
        {
            _tabs = tabs;
        }

        public static void SetPagePlugin(IPluginState state, IPlugin plugin)
        {
            if (_tabs.ActivePage != null)
                _tabs.ActivePage.SetPagePlugin(state, plugin);
        }

        public static void AddPage(string name = _defaultName)
        {
            Page page = new Page(name);
            _tabs.TabPages.Add(page);
            _tabs.SelectTab(page);
        }

        public static void RemovePage()
        {
            _tabs.TabPages.Remove(_tabs.ActivePage);
        }
        public static void RenamePage(string name)
        {
            _tabs.ActivePage.Text = name;
            _tabs.ActivePage.Name = name;
        }
    }
}
