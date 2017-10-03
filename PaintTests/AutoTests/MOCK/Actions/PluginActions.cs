using Paint.Command;
using Paint.Command.ActionInterface;
using Paint.Plugins.Manager;
using System;
using System.Windows.Forms;

namespace PaintTests.AutoTest.Actions
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
                MessageBox.Show("AddPlugin", "AddPlugin");
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
                MessageBox.Show("RemovePlugin", "RemovePlugin");
            }
        }
    }
}
