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
                (cmd as UCommand).Result = "Lang";
            }
        }
    }
}
