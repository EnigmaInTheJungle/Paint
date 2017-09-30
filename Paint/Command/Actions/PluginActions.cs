using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            }
        }
    }
}
