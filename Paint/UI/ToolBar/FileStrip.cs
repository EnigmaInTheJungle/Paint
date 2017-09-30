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
        public ToolStripItem[] FileStripList { get; }

        public FileStrip(XCommand command)
        {
            FileStripList = new ToolStripItem[]
            {
                new ToolStripButton(null,Properties.Resources.Save,command.Save.Action),
                new ToolStripButton(null, Properties.Resources.Load, command.Open.Action)
            };
        }
    }
}
