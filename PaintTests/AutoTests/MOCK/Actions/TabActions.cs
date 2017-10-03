

using Paint.Command;
using Paint.Command.ActionInterface;
using Paint.Plugins.Manager;
using Paint.UI.Managers;
using Paint.UI.TextInput;
using System;
using System.Windows.Forms;

namespace PaintTests.AutoTest.Actions
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
                MessageBox.Show("AddPage", "AddPage");
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
                MessageBox.Show("SelectPage", "SelectPage");
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
                MessageBox.Show("RemovePage", "RemovePage");
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
                MessageBox.Show("RemoveAllPages", "RemoveAllPages");
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
                MessageBox.Show("RenamePage", "RenamePage");
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
