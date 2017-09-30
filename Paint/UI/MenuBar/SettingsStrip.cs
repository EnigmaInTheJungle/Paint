using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.MenuBar
{
    class SettingsStrip : ToolStripMenuItem
    {
        ToolStripMenuItem langStrip;

        public SettingsStrip(XCommand command)
        {
            Name = "Settings";
            langStrip = MenuBar.GetDropDownStrip("Skin", new List<string>() { "Light", "Dark", "Pink" });

            DropDownItems.Add(new ToolStripSeparator());
            DropDownItems.Add(langStrip);
        }
    }
}
