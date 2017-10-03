using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.Managers
{
    public static class ToolManager
    {
        private static Bars.ToolBar _toolBar;

        public static void SetToolBar(Bars.ToolBar toolBar)
        {
            _toolBar = toolBar;
        }

        public static void AddPluginToolItems(ToolStripItem[] itemList)
        {
            _toolBar.Items.AddRange(itemList);
        }

        public static void RemovePluginToolItems(ToolStripItem[] itemList)
        {
            for (int i = 0; i < itemList.Length; i++)
            {
                _toolBar.Items.RemoveAt(_toolBar.Items.Count - 1);
            }
        }
    }
}
