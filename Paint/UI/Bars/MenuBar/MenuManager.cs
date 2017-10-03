using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paint.UI.Bars;
using System.Windows.Forms;

namespace Paint.UI.Managers
{
    public static class MenuManager
    {
        private static Bars.MenuBar _menuBar;
        private static ToolStripMenuItem _paintStrip;

        public static void SetMenuBar(Bars.MenuBar menuBar)
        {
            _menuBar = menuBar;
            _paintStrip = (_menuBar.Items["Paint"] as ToolStripMenuItem);
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
