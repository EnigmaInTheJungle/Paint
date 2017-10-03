

using Paint.Command;
using Paint.Command.ActionInterface;
using Paint.Plugins.Manager;
using Paint.UI.Managers;
using Paint.UI.TextInput;
using PaintTests.UnitTest.Command;
using System;
using System.Windows.Forms;

namespace PaintTests.UnitTest.Actions
{
    public static class TabActions
    {
        public class ActionAddPage : IAction
        {
            ICommand cmd;
            public ActionAddPage(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                (cmd as UCommand).Result = "AddPage";
            }
        }

        public class ActionSelectPage : IAction
        {
            ICommand cmd;
            public ActionSelectPage(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                (cmd as UCommand).Result = "SelectPage";
            }
        }

        public class ActionRemovePage : IAction
        {
            ICommand cmd;
            public ActionRemovePage(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                (cmd as UCommand).Result = "RemovePage";
            }
        }

        public class ActionRemoveAllPages : IAction
        {
            ICommand cmd;
            public ActionRemoveAllPages(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                (cmd as UCommand).Result = "RemoveAllPages";
            }
        }

        public class ActionRenamePage : IAction
        {
            ICommand cmd;
            public ActionRenamePage(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                (cmd as UCommand).Result = "RenamePage";
            }
        }

        public class ActionActiveFigure : IAction
        {
            ICommand cmd;
            public ActionActiveFigure(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
            }
        }
    }
}
