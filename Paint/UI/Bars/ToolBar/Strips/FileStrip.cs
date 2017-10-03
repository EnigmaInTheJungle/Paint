using Paint.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paint.UI.ToolBar.Strips
{
    public class FileStrip 
    {
        public ToolStripItem[] StripList { get; }

        public FileStrip(ICommand command)
        {
            StripList = new ToolStripItem[]
            {
                new ToolStripButton(null,Properties.Resources.Save,command.Save.Action,"Save"),
                new ToolStripButton(null, Properties.Resources.Load, command.Open.Action, "Open")        
            };
        }
    }
}
