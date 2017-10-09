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
    class WindowStrip : ToolStripMenuItem
    {
        ToolStripMenuItem renameStrip;
        ToolStripMenuItem closeStrip;
        ToolStripMenuItem closeAllStrip;

        public WindowStrip(ICommand command)
        {
            LanguageManager langMang = LanguageManager.GetInstance();
            Name = "Window";
            Text = langMang.GetValue(Name);

            renameStrip = new ToolStripMenuItem(langMang.GetValue("Rename"), null, command.RenamePage.Action, "Rename");
            closeStrip = new ToolStripMenuItem(langMang.GetValue("Close"), null, command.RemovePage.Action, "Close");
            closeAllStrip = new ToolStripMenuItem(langMang.GetValue("CloseAll"), null, command.RemoveAllPages.Action, "CloseAll");

            DropDownItems.Add(renameStrip);
            DropDownItems.Add(new ToolStripSeparator());


            DropDownItems.Add(new ToolStripSeparator());
            DropDownItems.Add(closeStrip);
            DropDownItems.Add(closeAllStrip);
        }
    }
}
