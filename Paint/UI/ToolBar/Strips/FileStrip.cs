using Paint.Command;
using Paint.Properties;
using Paint.Resources.Icons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paint.UI.Tool.Strips
{
    public class FileStrip 
    {
        public ToolStripItem[] StripList { get; }

        public FileStrip(ICommand command)
        {
            StripList = new ToolStripItem[]
            {
                new ToolStripButton(null, Icons.Save ,command.Save.Action,"Save"),
                new ToolStripButton(null, Icons.Load ,command.Open.Action, "Open")        
            };
        }
    }
}
