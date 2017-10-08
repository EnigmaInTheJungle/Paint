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
                    Data data = cmd.Data as Data;
                    data.Color = cd.Color;
                    cmd.Data = data;
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
                Data data = cmd.Data as Data;
                string type = "Rectangle";

                if (sender is ToolStripMenuItem)
                    type = (sender as ToolStripMenuItem).Text;
                else if (sender is ToolStripComboBox)
                    type = (sender as ToolStripComboBox).SelectedItem.ToString();

                switch (type)
                {
                    case "Rectangle": data.Type = FType.Rectangle; break;
                    case "Rounded Rectangle": data.Type = FType.RRectangle; break;
                    case "Ellipse": data.Type = FType.Ellipse; break;
                    case "Line": data.Type = FType.Line; break;
                }
                cmd.Data = data;
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
                Data data = cmd.Data as Data;

                if (sender is ToolStripMenuItem)
                    data.StrokeWidth = Convert.ToInt32((sender as ToolStripMenuItem).Text);
                else if (sender is ToolStripComboBox)
                    data.StrokeWidth = Convert.ToInt32((sender as ToolStripComboBox).SelectedItem.ToString());

                cmd.Data = data;
               
            }
        }
    }
}
