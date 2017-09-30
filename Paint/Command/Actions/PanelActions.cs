
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
        public class ActionSave
        {
            XCommand cmd;
            public ActionSave(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(string path)
            {            
                SOFactory.GetInstance(path).Save(cmd.Frame.Tab.ActivePage.DrawPanel.GetListOfFigures());
            }
        }
        public class ActionOpen
        {
            XCommand cmd;
            public ActionOpen(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(string path)
            {
                cmd.Frame.Tab.LoadPage(SOFactory.GetInstance(path).Open());
                cmd.Frame.MenuBar.AddPageStrip(cmd.Frame.Tab.SelectedTab.Text);
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
                cmd.Point = (e as MouseEventArgs).Location;
            }
        }
    }
}
