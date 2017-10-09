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
    class HelpStrip : ToolStripMenuItem
    {
        public HelpStrip(ICommand command)
        {
            LanguageManager langMang = LanguageManager.GetInstance();
            Name = "Help";
            Text = langMang.GetValue(Name);

            DropDownItems.Add(new ToolStripMenuItem(langMang.GetValue("ShowHelp"), null, null, "ShowHelp"));
            DropDownItems.Add(new ToolStripMenuItem(langMang.GetValue("About"), null, null, "About"));
        }
    }
}
