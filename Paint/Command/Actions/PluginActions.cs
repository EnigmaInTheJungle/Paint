using Paint.PluginManager;
using Paint.Plugins.SimpleFigurePlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                IPlugin plugin = null;
                switch((sender as ToolStripMenuItem).Text)
                {
                    case "Simple Figure": plugin = new SimpleFigure(cmd); break;
                }
                PluginManager.PluginManager.ConnectPlugin(plugin, cmd);
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
                IPlugin plugin = null;
                switch ((sender as ToolStripMenuItem).Text)
                {
                    case "Simple Figure": plugin = new SimpleFigure(cmd); break;
                }
                PluginManager.PluginManager.RemovePlugin(plugin, cmd);
            }
        }
    }
}
