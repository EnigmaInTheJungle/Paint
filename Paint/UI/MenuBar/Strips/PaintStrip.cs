using Paint.Command;
using Paint.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.Menu.Strips
{
    class PaintStrip : ToolStripMenuItem
    {
        public PaintStrip()
        {
            LanguageManager langMang = LanguageManager.GetInstance();
            Name = "Paint";
            Text = langMang.GetValue(Name);
        }

        public void AddPluginMenuItems(List<ToolStripMenuItem> itemList)
        {
            foreach (ToolStripMenuItem item in itemList)
            {
                DropDownItems.Add(item);
            }
        }

        public void RemovePluginMenuItems()
        {
            DropDownItems.Clear();
        }
    }
}
