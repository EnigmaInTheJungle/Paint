

using Paint.Command.ActionInterface;
using Paint.Plugins.Manager;
using Paint.UI.Managers;
using Paint.UI.TextInput;
using System;
using System.Windows.Forms;

namespace Paint.Command.Actions
{
    public class TabActions
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
                TabsManager.AddPage();
                if (cmd.ActivePlugin != null)
                {
                    cmd.ActivePluginState = cmd.ActivePlugin.GetNewState;
                    TabsManager.SetPagePlugin(cmd.ActivePluginState, cmd.ActivePlugin);
                }
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
                if (cmd.ActivePlugin != null)
                {
                    MenuManager.RemovePluginMenuItems();
                    ToolManager.RemovePluginToolItems(cmd.ActivePlugin.GetToolBarItems());
                }
                if (TabsManager.PagePlugin != null)
                {
                    cmd.ActivePlugin = TabsManager.PagePlugin;
                }
                    MenuManager.AddPluginMenuItems(cmd.ActivePlugin.GetMenuBarItems());
                    ToolManager.AddPluginToolItems(cmd.ActivePlugin.GetToolBarItems());

                    cmd.ActivePluginState = TabsManager.PageState;
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
                TabsManager.RemovePage();
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
                TextInput inputForm = new TextInput();

                if (inputForm.ShowDialog() == DialogResult.OK)
                    TabsManager.RenamePage(inputForm.resultTxt.Text);

                inputForm.Dispose();              
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
                //if (cmd.Frame.Tab.ActiveFigure != null && figureControl == null)
                //    cmd.Frame.Tab.ActiveFigure.BorderStyle = System.Windows.Forms.BorderStyle.None;

                //cmd.Frame.Tab.ActiveFigure = figureControl;
            }
        }
    }
}
