using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paint.UI.Bars;
using System.Windows.Forms;
using Paint.Plugins;
using Paint.UI.MenuBar.Strips;

namespace Paint.UI.Managers
{
    public static class MenuManager
    {
        private static Bars.MenuBar _menuBar;
        private static PaintStrip _paintStrip;
        private static SettingsStrip _settingsStrip;

        private static int _defPluginCount = 2;

        public static void SetMenuBar(Bars.MenuBar menuBar)
        {
            _menuBar = menuBar;
            _paintStrip = (_menuBar.Items["Paint"] as PaintStrip);
            _settingsStrip = (_menuBar.Items["Settings"] as SettingsStrip);
        }

        public static void AddPluginsToMenu(ICollection<IPlugin> plugins)
        {
            foreach (IPlugin plugin in plugins)
            {
                _settingsStrip.DropDownItems.Insert(0, new ToolStripMenuItem(plugin.Name, null, _settingsStrip.ChangeState, plugin.Name));

                if (--_defPluginCount >= 0)
                {
                    _settingsStrip.ChangeState((_settingsStrip.DropDownItems[0] as ToolStripMenuItem), new EventArgs());
                }
            }
        }

        public static ToolStripMenuItem GetDropDownStrip(string ownerText, List<string> items, EventHandler onClick = null)
        {
            ToolStripMenuItem owner = new ToolStripMenuItem(ownerText, null, null, ownerText);
            foreach (string itemText in items)
            {
                owner.DropDownItems.Add(new ToolStripMenuItem(itemText, null, onClick, itemText));
            }
            return owner;
        }
        public static void AddPluginMenuItems(List<ToolStripMenuItem> itemList)
        {
            foreach (ToolStripMenuItem item in itemList)
            {
                _paintStrip.DropDownItems.Add(item);
            }
        }
        public static void RemovePluginMenuItems()
        {
            _paintStrip.DropDownItems.Clear();
        }
    }
}
