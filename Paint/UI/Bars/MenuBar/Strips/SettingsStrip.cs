using Paint.Command;
using Paint.Plugins.SimpleFigurePlugin;
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

            langStrip = MenuManager.GetDropDownStrip("Language", new List<string>() { "English", "Russian", "Ukrainian" }, command.ChangeLanguage.Action);

            DropDownItems.Add(new ToolStripMenuItem("Simple Figure", null, ChangeState, "Simple Figure"));
            DropDownItems.Add(new ToolStripMenuItem("Figure with text", null, ChangeState, "Figure with text"));
            DropDownItems.Add(new ToolStripSeparator());
            DropDownItems.Add(langStrip);

            (DropDownItems[0] as ToolStripMenuItem).CheckState = CheckState.Checked;
            (DropDownItems[1] as ToolStripMenuItem).CheckState = CheckState.Checked;
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
