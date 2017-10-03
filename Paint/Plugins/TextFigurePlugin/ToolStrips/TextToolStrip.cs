using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Plugins.TextFigurePlugin
{
    public class TextToolStrip 
    {
        public ToolStripItem[] StripList { get; }

        public TextToolStrip(Command.Command command)
        {
            StripList = new ToolStripItem[9];

            StripList[0] = new ToolStripButton(Properties.Resources.TextInput);
            StripList[1] = new ToolStripButton(Properties.Resources.TextPos1);
            StripList[2] = new ToolStripButton(Properties.Resources.TextPos2);
            StripList[3] = new ToolStripButton(Properties.Resources.LSideAlign);
            StripList[4] = new ToolStripButton(Properties.Resources.CenterAling);
            StripList[5] = new ToolStripButton(Properties.Resources.RSideAlign);
            StripList[6] = new ToolStripButton(Properties.Resources.RotateTextR);
            StripList[7] = new ToolStripButton(Properties.Resources.RotateTextL);
            StripList[8] = new ToolStripSeparator();
        }
    }
}
