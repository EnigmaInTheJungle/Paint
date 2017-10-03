using Paint.Plugins.Manager;
using System;
using System.Windows.Forms;

namespace Paint.Command.Actions
{
    public class PluginActions
    {
        public class ActionAddPlugin
        {
            XCommand cmd;
            public ActionAddPlugin(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                PluginManager.ConnectPlugin((sender as ToolStripMenuItem).Text);
            }
        }

        public class ActionRemovePlugin
        {
            XCommand cmd;
            public ActionRemovePlugin(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                PluginManager.RemovePlugin((sender as ToolStripMenuItem).Text);
            }
        }
    }
}
