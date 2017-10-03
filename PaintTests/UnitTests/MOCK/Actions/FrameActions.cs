
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
    public static class FrameActions
    {
        public class ActionSaveAs : IAction
        {
            ICommand cmd;
            public ActionSaveAs(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                (cmd as UCommand).Result = "SaveAs";
            }
        }

        public class ActionSave : IAction
        {
            ICommand cmd;
            public ActionSave(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                (cmd as UCommand).Result = "Save";
            }
        }

        public class ActionOpen : IAction
        {
            ICommand cmd;
            public ActionOpen(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                (cmd as UCommand).Result = "Open";
            }
        }

        public class ActionStatus : IAction
        {
            ICommand cmd;
            public ActionStatus(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {

            }
        }
    }
}
