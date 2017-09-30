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
            Text = "Settings";
            langStrip = MenuBar.GetDropDownStrip("Language", new List<string>() { "English", "Russian", "Ukrainian" }, command.ChangeLanguage.Action);

            DropDownItems.Add(new ToolStripSeparator());
            DropDownItems.Add(langStrip);
        }
    }
}
