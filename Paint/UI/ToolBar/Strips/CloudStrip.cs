using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Paint.Command;
using Paint.Properties;
using Paint.Resources.Icons;

namespace Paint.UI.Tool.Strips
{
    class CloudStrip 
    {
        public ToolStripItem[] StripList { get;  }

        public CloudStrip(ICommand command)
        {
            StripList = new ToolStripItem[]
            {
                new ToolStripButton(null,Icons.SaveC,command.SaveCloud.Action, "Save Cloud"),
                new ToolStripButton(null,Icons.LoadC, command.LoadCloud.Action, "Load Cloud")
            };
        }
    }
}
