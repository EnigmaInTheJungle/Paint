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
    class CloudStrip : ToolStrip
    {
        ToolStripItem[] cloudStrip;
        XCommand command;

        public ToolStripItem[] GetCloudStrip()
        {
            string saveCloudIcon = @"Resources\Image Icon\SaveC.PNG";
            string openCloudIcon = @"Resources\Image Icon\LoadC.PNG";

            cloudStrip = new ToolStripItem[]
            {
                new ToolStripButton("Save",new Bitmap(saveCloudIcon),null),
                new ToolStripButton("Open", new Bitmap(openCloudIcon), null)
            };
            return cloudStrip;
        }
    }
}
