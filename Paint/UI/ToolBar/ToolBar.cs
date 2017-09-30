using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.ToolBar
{
    public class ToolBar : ToolStrip
    {
        FileStrip fileStrip;
        CloudStrip cloudStrip;
        public ToolBar()
        {
            Dock = DockStyle.Top;

            Items.AddRange(fileStrip.GetFileStrip());
            Items.Add(new ToolStripSeparator());
            Items.AddRange(cloudStrip.GetCloudStrip());
            Items.Add(new ToolStripSeparator());
        }
        
    }
}
