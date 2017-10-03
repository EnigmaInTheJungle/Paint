using Paint.Command;
using Paint.Command.ActionInterface;
using System;
using System.Windows.Forms;

namespace PaintTests.AutoTest.Actions
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
                MessageBox.Show("ChangeSkin", "ChangeSkin");
            }
        }
    }
}
