
using System;
using System.Windows.Forms;
using static SimpleFigurePlugin.Data;

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
                    if (Command.Command.ActiveFigure == null)
                        cmd.Data.Color = cd.Color;
                    else
                        Command.Command.ActiveFigure.SetFigureColor(cd.Color);
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


                FType ftype = FType.Rectangle;

                switch (type)
                {
                    case "Rectangle": ftype = FType.Rectangle; break;
                    case "Rounded Rectangle": ftype = FType.RRectangle; break;
                    case "Ellipse": ftype = FType.Ellipse; break;
                    case "Line": ftype = FType.Line; break;
                }

                if (Command.Command.ActiveFigure == null)
                    cmd.Data.Type = ftype;
                else
                    Command.Command.ActiveFigure.SetFigureType(ftype);
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
                if (Command.Command.ActiveFigure == null)
                {
                    if (sender is ToolStripMenuItem)
                        cmd.Data.StrokeWidth = Convert.ToInt32((sender as ToolStripMenuItem).Text);
                    else if (sender is ToolStripComboBox)
                        cmd.Data.StrokeWidth = Convert.ToInt32((sender as ToolStripComboBox).SelectedItem.ToString());
                }
                else
                {
                    if (sender is ToolStripMenuItem)
                        Command.Command.ActiveFigure.SetStrokeWidth(Convert.ToInt32((sender as ToolStripMenuItem).Text));
                    else if (sender is ToolStripComboBox)
                        Command.Command.ActiveFigure.SetStrokeWidth(Convert.ToInt32((sender as ToolStripComboBox).SelectedItem.ToString()));
                }
               
            }
        }
    }
}
