using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.MenuBar.Strips
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

        public FileStrip(ICommand command)
        {
            Text = "File";
            Name = "File";

            newStrip = new ToolStripMenuItem("New", null, command.AddPage.Action, "New");
            openStrip = new ToolStripMenuItem("Open", null, command.Open.Action, "Open");
            saveStrip = new ToolStripMenuItem("Save", null, command.Save.Action, "Save");
            saveAsStrip = new ToolStripMenuItem("Save as..", null, command.SaveAs.Action, "Save as..");
            saveCloudStrip = new ToolStripMenuItem("Save in Cloud", null, command.SaveCloud.Action, "Save in Cloud");
            loadCloudStrip = new ToolStripMenuItem("Load from Cloud", null, command.LoadCloud.Action, "Load from Cloud");
            exitStrip = new ToolStripMenuItem("Exit", null, delegate { Application.Exit(); });

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
