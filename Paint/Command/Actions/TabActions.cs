

using Paint.Plugins.Manager;
using Paint.UI.Managers;
using Paint.UI.TextInput;
using System;
using System.Windows.Forms;

namespace Paint.Command.Actions
{
    public static class TabActions
    {
        public class ActionAddPage
        {
            XCommand cmd;
            public ActionAddPage(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                TabsManager.AddPage();
                if (PluginManager.ActivePlugin != null)
                {
                    TabsManager.SetPluginData(PluginManager.ActivePlugin.GetNewData());
                    cmd.Data = TabsManager.ActivePage.ActiveData;
                }
            }
        }

        public class ActionSelectPage
        {
            XCommand cmd;
            public ActionSelectPage(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                //cmd.Frame.Tab.SelectedTab = cmd.Frame.Tab.TabPages[cmd.Frame.Tab.TabPages.IndexOfKey(name)];
            }
        }

        public class ActionRemovePage
        {
            XCommand cmd;
            public ActionRemovePage(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                TabsManager.RemovePage();
            }
        }

        public class ActionRemoveAllPages
        {
            XCommand cmd;
            public ActionRemoveAllPages(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
              
            }
        }

        public class ActionRenamePage
        {
            XCommand cmd;
            public ActionRenamePage(XCommand cmd)
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

        public class ActionActiveFigure
        {
            XCommand cmd;
            public ActionActiveFigure(XCommand cmd)
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
