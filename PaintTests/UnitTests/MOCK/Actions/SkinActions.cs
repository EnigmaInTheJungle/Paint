using Paint.Command;
using Paint.Command.ActionInterface;
using PaintTests.UnitTest.Command;
using System;
using System.Windows.Forms;

namespace PaintTests.UnitTest.Actions
{
    public class SkinActions
    {
        public class ActionChangeSkin : IAction
        {
            ICommand cmd;
            public ActionChangeSkin(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                (cmd as UCommand).Result = "ChangeSkin";
            }
        }
    }
}
