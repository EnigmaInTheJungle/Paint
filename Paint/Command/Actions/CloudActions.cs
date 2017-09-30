using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Command.Actions
{
    public class CloudActions
    {
        public class ActionSaveCloud
        {
            XCommand cmd;
            public ActionSaveCloud(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
            }
        }

        public class ActionLoadCloud
        {
            XCommand cmd;
            public ActionLoadCloud(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
            }
        }
    }
}
