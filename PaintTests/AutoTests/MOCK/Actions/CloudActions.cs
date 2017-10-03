
using Paint.Command;
using Paint.Command.ActionInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTests.AutoTest.Actions
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
                MessageBox.Show("SaveCloud", "SaveCloud");
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
                MessageBox.Show("LoadCloud", "LoadCloud");
            }
        }
    }
}
