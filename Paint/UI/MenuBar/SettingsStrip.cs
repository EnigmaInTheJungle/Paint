using Paint.Command;
using Paint.Plugins.SimpleFigurePlugin;
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
        XCommand _command;

        public SettingsStrip(XCommand command)
        {
            _command = command;

            Text = "Settings";
            langStrip = MenuBar.GetDropDownStrip("Language", new List<string>() { "English", "Russian", "Ukrainian" }, command.ChangeLanguage.Action);

            DropDownItems.Add(new ToolStripMenuItem("Simple Figure", null, ChangeState));
            DropDownItems.Add(new ToolStripSeparator());
            DropDownItems.Add(langStrip);
        }


        private void ChangeState(object sender, EventArgs e)
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
