using Paint.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paint.UI.ToolBar 
{
    public class FileStrip : ToolStrip
    {
        ToolStripItem[] fileStrip;
        XCommand command;

        public ToolStripItem[] GetFileStrip()
        {
            string saveIcon = @"Resources\Image Icon\Save.PNG";
            string openIcon = @"Resources\Image Icon\Load.PNG";

            fileStrip = new ToolStripItem[]
            {
                new ToolStripButton("Save",new Bitmap(saveIcon),command.Save.Action),
                new ToolStripButton("Open", new Bitmap(openIcon), command.Open.Action)
            };

            return fileStrip;
        }
    }
}
