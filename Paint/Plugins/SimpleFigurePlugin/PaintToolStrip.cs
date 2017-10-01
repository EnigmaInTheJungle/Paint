using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Plugins.SimpleFigurePlugin
{
    public class PaintToolStrip 
    {
        public ToolStripItem[] FileStripList { get; }

        public PaintToolStrip(Command.Command command)
        {
            FileStripList = new ToolStripItem[4];

            ToolStripComboBox cbWidth = new ToolStripComboBox("StrokeWidth");
            cbWidth.Items.AddRange(new object[] { "1", "5", "10" });
            cbWidth.SelectedIndexChanged += command.ChangeWidth.Action;
            cbWidth.SelectedIndex = 0;
            cbWidth.AutoSize = true;

            ToolStripComboBox cbType = new ToolStripComboBox();
            cbType.Items.AddRange(new object[] { "Free pencil", "Rectangle", "Ellipse", "Rounded Rectangle", "Line" });
            cbType.SelectedIndexChanged += command.ChangeType.Action;
            cbType.SelectedIndex = 0; 

            ToolStripButton bColor = new ToolStripButton(null, Properties.Resources.Color, command.ChangeColor.Action);

            FileStripList[0] = bColor;
            FileStripList[1] = cbWidth;
            FileStripList[2] = cbType;
            FileStripList[3] = new ToolStripSeparator();
        }
    }
}
