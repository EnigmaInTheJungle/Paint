using Paint.Command.ActionInterface;
using Paint.Plugins.Manager;
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
                PluginManager.ConnectPlugin((sender as ToolStripMenuItem).Name);
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
                PluginManager.RemovePlugin((sender as ToolStripMenuItem).Name);
            }
        }
    }
}
