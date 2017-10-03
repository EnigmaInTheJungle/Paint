
using Paint.Command;
using Paint.Command.ActionInterface;
using PaintTests.UnitTest.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTests.UnitTest.Actions
{
    public class CloudActions
    {
        public class ActionSaveCloud : IAction
        {
            ICommand cmd;
            public ActionSaveCloud(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                (cmd as UCommand).Result = "SaveCloud";
            }
        }

        public class ActionLoadCloud : IAction
        {
            ICommand cmd;
            public ActionLoadCloud(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                (cmd as UCommand).Result = "LoadCloud";
            }
        }
    }
}
