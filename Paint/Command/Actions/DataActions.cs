using Paint.Data;
using Paint.UI.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Command.Actions
{
    public class DataActions
    {
        public class ActionUpdateData
        {
            XCommand cmd;
            public ActionUpdateData(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(IData data)
            {
                TabsManager.SetPluginData(data);
            }
        }
    }
}
