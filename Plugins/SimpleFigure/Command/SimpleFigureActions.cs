using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimpleFigurePlugin.Data;
using SimpleFigurePlugin.Command;

namespace SimpleFigurePlugin
{
    public class SimpleFigureActions
    {
        public class ActionChangeColor
        {
            Command.Command cmd;
            public ActionChangeColor(Command.Command cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                ColorDialog cd = new ColorDialog();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    cmd.Data.Color = cd.Color;
                }
            }
        }

        public class ActionChangeType
        {
            Command.Command cmd;
            public ActionChangeType(Command.Command cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                string type = "Rectangle";

                if (sender is ToolStripMenuItem)
                    type = (sender as ToolStripMenuItem).Text;
                else if (sender is ToolStripComboBox)
                    type = (sender as ToolStripComboBox).SelectedItem.ToString();

                switch (type)
                {
                    case "Rectangle": cmd.Data.Type = FType.Rectangle; break;
                    case "Rounded Rectangle": cmd.Data.Type = FType.RRectangle; break;
                    case "Ellipse": cmd.Data.Type = FType.Ellipse; break;
                    case "Line": cmd.Data.Type = FType.Line; break;
                }
            }
        }

        public class ActionChangeWidth
        {
            Command.Command cmd;
            public ActionChangeWidth(Command.Command cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                if (sender is ToolStripMenuItem)
                    cmd.Data.StrokeWidth = Convert.ToInt32((sender as ToolStripMenuItem).Text);
                else if (sender is ToolStripComboBox)
                    cmd.Data.StrokeWidth = Convert.ToInt32((sender as ToolStripComboBox).SelectedItem.ToString());
               
            }
        }
    }
}
