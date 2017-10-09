
using System.Windows.Forms;
using TextFigure.Properties;

namespace TextFigurePlugin
{
    public class TextToolStrip 
    {
        public ToolStripItem[] StripList { get; }

        public TextToolStrip(Command.Command command)
        {
            StripList = new ToolStripItem[9];

            StripList[0] = new ToolStripButton(Resource.TextInput);
            StripList[1] = new ToolStripButton(Resource.TextPos1);
            StripList[2] = new ToolStripButton(Resource.TextPos2);
            StripList[3] = new ToolStripButton(Resource.LSideAlign);
            StripList[4] = new ToolStripButton(Resource.CenterAling);
            StripList[5] = new ToolStripButton(Resource.RSideAlign);
            StripList[6] = new ToolStripButton(Resource.RotateTextR);
            StripList[7] = new ToolStripButton(Resource.RotateTextL);
            StripList[8] = new ToolStripSeparator();
        }
    }
}
