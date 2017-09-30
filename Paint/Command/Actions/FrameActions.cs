
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Command.Actions
{
    public static class FrameActions
    {
        public class ActionSaveAs
        {
            XCommand cmd;
            public ActionSaveAs(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                SaveFileDialog dlgSave = new SaveFileDialog();
                string[] ext = { "JSON (*.json)|*.json", "XML (*.xml) | *.xml", "YAML (*.yaml)|*.yaml" };
                dlgSave.Filter = String.Join("|", ext);
                if (dlgSave.ShowDialog() == DialogResult.OK)
                {
                    //SOFactory.GetInstance(dlgSave.FileName).Save(cmd.Frame.Tab.ActivePage.DrawPanel.GetListOfFigures());
                }
            }
        }

        public class ActionSave
        {
            XCommand cmd;
            public ActionSave(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                //SOFactory.GetInstance(dlgSave.FileName).Save(cmd.Frame.Tab.ActivePage.DrawPanel.GetListOfFigures());
            }
        }

        public class ActionOpen
        {
            XCommand cmd;
            public ActionOpen(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                OpenFileDialog dlgOpen = new OpenFileDialog();
                string ext = "SO (*.json; *.xml; *.yaml)| *.json; *.xml; *.yaml";
                dlgOpen.Filter = ext;
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    //cmd.Frame.Tab.LoadPage(SOFactory.GetInstance(dlgOpen.FileName).Open());
                    //cmd.Frame.MenuBar.AddPageStrip(cmd.Frame.Tab.SelectedTab.Text);
                }
            }
        }

        public class ActionStatus
        {
            XCommand cmd;
            public ActionStatus(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                //cmd.Point = (e as MouseEventArgs).Location;
            }
        }
    }
}
