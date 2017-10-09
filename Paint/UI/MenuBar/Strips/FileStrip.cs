using Paint.Command;
using Paint.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.Menu.Strips
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
            LanguageManager langMang = LanguageManager.GetInstance();
            Name = "File";
            Text = langMang.GetValue(Name);

            

            newStrip = new ToolStripMenuItem(langMang.GetValue("New"), null, command.AddPage.Action, "New");
            openStrip = new ToolStripMenuItem(langMang.GetValue("Open"), null, command.Open.Action, "Open");
            saveStrip = new ToolStripMenuItem(langMang.GetValue("Save"), null, command.Save.Action, "Save");
            saveAsStrip = new ToolStripMenuItem(langMang.GetValue("SaveAs"), null, command.SaveAs.Action, "SaveAs");
            saveCloudStrip = new ToolStripMenuItem(langMang.GetValue("SaveC"), null, command.SaveCloud.Action, "SaveC");
            loadCloudStrip = new ToolStripMenuItem(langMang.GetValue("LoadC"), null, command.LoadCloud.Action, "LoadC");
            exitStrip = new ToolStripMenuItem(langMang.GetValue("Exit"), null, delegate { Application.Exit(); }, "Exit");

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
