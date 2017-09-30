using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.Menu
{
    class FileStrip : ToolStripMenuItem
    {
        ToolStripMenuItem newStrip;
        ToolStripMenuItem openStrip;
        ToolStripMenuItem saveStrip;
        ToolStripMenuItem saveAsStrip;
        ToolStripMenuItem saveCloudStrip;
        ToolStripMenuItem loadCloudStrip;
        ToolStripMenuItem exitStrip;

        public FileStrip(XCommand command)
        {
            Name = "File";

            newStrip = new ToolStripMenuItem("Load", null, command.AddPage.Action);

        }

    }
}
