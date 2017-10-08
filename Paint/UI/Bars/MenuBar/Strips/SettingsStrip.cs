using Paint.Command;
using Paint.Plugins;
using Paint.Plugins.Manager;

using Paint.UI.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.MenuBar.Strips
{
    class SettingsStrip : ToolStripMenuItem
    {
        ToolStripMenuItem langStrip;
        ICommand _command;

        public SettingsStrip(ICommand command)
        {
            _command = command;

            Text = "Settings";
            Name = "Settings";

            DropDownItems.Add(new ToolStripSeparator());
            DropDownItems.Add(MenuManager.GetDropDownStrip("Language", new List<string>() { "English", "Russian", "Ukrainian" }, command.ChangeLanguage.Action));
        }


        public void ChangeState(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item.CheckState == CheckState.Unchecked)
            {
                item.CheckState = CheckState.Checked;
                _command.AddPlugin.Action(sender, e);
            }
            else
            {
                item.CheckState = CheckState.Unchecked;
                _command.RemovePlugin.Action(sender, e);
            }
        }
    }
}
