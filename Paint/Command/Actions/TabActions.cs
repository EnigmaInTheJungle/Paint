

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
                if (PluginManager.ActivePlugin != null)
                {
                    TabsManager.SetPluginData(PluginManager.ActivePlugin.GetNewData(), PluginManager.ActivePlugin.ActiveFigure);
                    cmd.Data = TabsManager.ActivePage.ActiveData;
                    cmd.ActiveFigure = TabsManager.ActivePage.ViewPanel.ActiveFigure;
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
                //cmd.Frame.Tab.SelectedTab = cmd.Frame.Tab.TabPages[cmd.Frame.Tab.TabPages.IndexOfKey(name)];
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
