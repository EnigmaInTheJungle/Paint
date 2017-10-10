using Paint.Command;
using Paint.Managers;
using PluginInterface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Paint.UI.Menu.Strips
{
    class SettingsStrip : ToolStripMenuItem
    {
        private int _defPluginCount = 2;
        ICommand _command;

        public SettingsStrip(ICommand command)
        {
            _command = command;

            LanguageManager langMang = LanguageManager.GetInstance();
            Name = "Settings";
            Text = langMang.GetValue(Name);

            DropDownItems.Add(new ToolStripSeparator());
            DropDownItems.Add(MenuBar.GetDropDownStrip("Language", new List<string>() { "English", "Russian", "Ukrainian" }, command.ChangeLanguage.Action));
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

        public void AddPluginsToMenu(ICollection<IPlugin> plugins)
        {
            foreach (IPlugin plugin in plugins)
            {
                DropDownItems.Insert(0, new ToolStripMenuItem(plugin.Name, null, ChangeState, plugin.Name));

                if (--_defPluginCount >= 0)
                    ChangeState(DropDownItems[0], new EventArgs());
            }
        }
    }
}
