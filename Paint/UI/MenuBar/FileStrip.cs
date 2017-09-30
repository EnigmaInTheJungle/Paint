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

            newStrip = new ToolStripMenuItem("New", null, command.AddPage.Action);
            openStrip = new ToolStripMenuItem("Open", null, command.Open.Action);
            saveStrip = new ToolStripMenuItem("Save", null, command.Save.Action);
            saveAsStrip = new ToolStripMenuItem("Save as..", null, command.Save.Action);
            saveCloudStrip = new ToolStripMenuItem("Save in Cloud", null);
            loadCloudStrip = new ToolStripMenuItem("Load from Cloud", null);
            exitStrip = new ToolStripMenuItem("Exit", null);

            DropDownItems.Add(newStrip);
            DropDownItems.Add(openStrip);
            DropDownItems.Add(new ToolStripSeparator());

            DropDownItems.Add(saveStrip);
            DropDownItems.Add(saveAsStrip);
            DropDownItems.Add(new ToolStripSeparator());

            DropDownItems.Add(saveCloudStrip);
            DropDownItems.Add(loadCloudStrip);
            DropDownItems.Add(new ToolStripSeparator());

            DropDownItems.Add(exitStrip);
        }

    }
}
