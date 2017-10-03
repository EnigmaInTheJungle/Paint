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
    public class LanguageActions
    {
        public class ActionChangeLanguage : IAction
        {
            ICommand cmd;
            public ActionChangeLanguage(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                MessageBox.Show("Lang", "Lang");
            }
        }
    }
}
