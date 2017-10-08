using Paint.Command;
using Paint.Data;
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
        public static Page ActivePage => _tabs.ActivePage;

        public static void SetTabs(Tabs.Tabs tabs)
        {
            _tabs = tabs;
        }

        public static void SetPluginData(IData data, Control figure)
        {
            if (ActivePage != null)
            {
                ActivePage.ViewPanel.Data = data;
                ActivePage.ViewPanel.ActiveFigure = figure;
                _tabs.PullActiveData();
            }
        }

        public static void AddPage(string name = _defaultName)
        {
            Page page = new Page(name);
            _tabs.TabPages.Add(page);
            _tabs.SelectTab(page);
        }

        public static void RemovePage()
        {
            _tabs.TabPages.Remove(ActivePage);
        }
        public static void RenamePage(string name)
        {
            ActivePage.Text = name;
            ActivePage.Name = name;
        }
    }
}
