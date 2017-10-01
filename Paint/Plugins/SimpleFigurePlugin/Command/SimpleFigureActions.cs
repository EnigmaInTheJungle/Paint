using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Paint.Plugins.SimpleFigurePlugin.Data;

namespace Paint.Plugins.SimpleFigurePlugin
{
    public class SimpleFigureActions
    {
        public class ActionChangeColor
        {
            XCommand cmd;
            public ActionChangeColor(XCommand cmd)
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
            XCommand cmd;
            public ActionChangeType(XCommand cmd)
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
                    case "Free pencil": data.Type = FType.Curve; break;
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
            XCommand cmd;
            public ActionChangeWidth(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                Data data = cmd.Data as Data;
                if(sender is ToolStripMenuItem)
                    data.StrokeWidth = Convert.ToInt32((sender as ToolStripMenuItem).Text);
                else if (sender is ToolStripComboBox)
                    data.StrokeWidth = Convert.ToInt32((sender as ToolStripComboBox).SelectedItem.ToString());
                cmd.Data = data;
            }
        }
    }
}
