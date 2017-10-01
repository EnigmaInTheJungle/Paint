using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Paint.Command;

namespace Paint.UI.ToolBar
{
    class CloudStrip 
    {
        public ToolStripItem[] CloudStripList { get;  }

        public CloudStrip(XCommand command)
        {
            CloudStripList = new ToolStripItem[]
            {
                new ToolStripButton(null,Properties.Resources.SaveC,command.SaveCloud.Action),
                new ToolStripButton(null,Properties.Resources.LoadC, command.LoadCloud.Action)
            };
        }
    }
}
