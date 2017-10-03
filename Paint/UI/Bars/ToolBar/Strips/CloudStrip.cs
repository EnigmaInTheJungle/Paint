using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Paint.Command;

namespace Paint.UI.ToolBar.Strips
{
    class CloudStrip 
    {
        public ToolStripItem[] StripList { get;  }

        public CloudStrip(XCommand command)
        {
            StripList = new ToolStripItem[]
            {
                new ToolStripButton(null,Properties.Resources.SaveC,command.SaveCloud.Action, "Save Cloud"),
                new ToolStripButton(null,Properties.Resources.LoadC, command.LoadCloud.Action, "Load Cloud")
            };
        }
    }
}
