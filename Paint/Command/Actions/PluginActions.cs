using Paint.Command.ActionInterface;
using Paint.Plugins;
using Paint.Plugins.Manager;
using Paint.UI.Managers;
using System;
using System.Windows.Forms;

namespace Paint.Command.Actions
{
    public class PluginActions
    {
        public class ActionAddPlugin : IAction
        {
            ICommand cmd;
            public ActionAddPlugin(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                if (PluginManager.GetPluginByName((sender as ToolStripMenuItem).Name) != null)
                {
                    PluginPanelManager.AddPluginElement(PluginManager.CreatePluginElement((sender as ToolStripMenuItem).Name));
                }
            }
        }

        public class ActionRemovePlugin : IAction
        {
            ICommand cmd;
            public ActionRemovePlugin(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                if (PluginManager.GetPluginByName((sender as ToolStripMenuItem).Name) != null)
                {
                    if (cmd.ActivePlugin != null)
                    {
                        MenuManager.RemovePluginMenuItems();
                        ToolManager.RemovePluginToolItems(cmd.ActivePlugin.GetToolBarItems());
                    }
                    PluginPanelManager.RemovePluginElement((sender as ToolStripMenuItem).Name);
                    cmd.ActivePlugin = null;
                }
            }
        }

        public class ActionSetActivePlugin
        {
            ICommand cmd;
            public ActionSetActivePlugin(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(IPlugin plugin)
            {
                if (cmd.ActivePlugin != null)
                {
                    MenuManager.RemovePluginMenuItems();
                    ToolManager.RemovePluginToolItems(cmd.ActivePlugin.GetToolBarItems());
                }
                cmd.ActivePlugin = plugin;
                cmd.ActivePluginState = plugin.GetNewState;

                MenuManager.AddPluginMenuItems(plugin.GetMenuBarItems());
                ToolManager.AddPluginToolItems(plugin.GetToolBarItems());

                TabsManager.SetPagePlugin(cmd.ActivePluginState, cmd.ActivePlugin);
            }
        }             
    }
}
