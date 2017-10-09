
using System.Windows.Forms;
using TextFigure.Properties;

namespace TextFigurePlugin
{
    public class FigureToolStrip 
    {
        public ToolStripItem[] StripList { get; }

        public FigureToolStrip(Command.Command command)
        {
            StripList = new ToolStripItem[4];

            ToolStripComboBox cbWidth = new ToolStripComboBox("StrokeWidth");
            cbWidth.Items.AddRange(new object[] { "1", "5", "10" });
            cbWidth.SelectedIndex = 0;
            cbWidth.SelectedIndexChanged += command.ChangeWidth.Action;
            cbWidth.AutoSize = true;

            ToolStripComboBox cbType = new ToolStripComboBox();
            cbType.Items.AddRange(new object[] {"Rectangle", "Ellipse", "Rounded Rectangle", "Line" });
            cbType.SelectedIndex = 0;
            cbType.SelectedIndexChanged += command.ChangeType.Action;

            ToolStripButton bColor = new ToolStripButton(null, Resource.Color, command.ChangeColor.Action);

            StripList[0] = bColor;
            StripList[1] = cbWidth;
            StripList[2] = cbType;
            StripList[3] = new ToolStripSeparator();
        }
    }
}
