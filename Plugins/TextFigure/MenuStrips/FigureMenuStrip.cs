
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFigurePlugin
{
    public class FigureMenuStrip : ToolStripMenuItem
    {
        ToolStripMenuItem colorStrip;
        ToolStripMenuItem widthStrip;

        ToolStripMenuItem lineStrip;
        ToolStripMenuItem rectStrip;
        ToolStripMenuItem ellipseStrip;
        ToolStripMenuItem rrectStrip;

        public FigureMenuStrip(Command.Command command)
        {
            Text = "Figure";
            Name = "Figure";

            colorStrip = new ToolStripMenuItem("Color", null, command.ChangeColor.Action);
            widthStrip = GetDropDownStrip("Width", new List<string>() { "1", "5", "10" }, command.ChangeWidth.Action);
            lineStrip = new ToolStripMenuItem("Line", null, command.ChangeType.Action);
            rectStrip = new ToolStripMenuItem("Rectangle", null, command.ChangeType.Action);
            ellipseStrip = new ToolStripMenuItem("Ellipse", null, command.ChangeType.Action);
            rrectStrip = new ToolStripMenuItem("Rounded Rectangle", null, command.ChangeType.Action);

            DropDownItems.Add(colorStrip);
            DropDownItems.Add(widthStrip);
            DropDownItems.Add(new ToolStripSeparator());

            DropDownItems.Add(lineStrip);
            DropDownItems.Add(rectStrip);
            DropDownItems.Add(ellipseStrip);
            DropDownItems.Add(rrectStrip);

        }

        private ToolStripMenuItem GetDropDownStrip(string ownerText, List<string> items, EventHandler onClick = null)
        {
            ToolStripMenuItem owner = new ToolStripMenuItem(ownerText, null, null, ownerText);
            foreach (string itemText in items)
            {
                owner.DropDownItems.Add(new ToolStripMenuItem(itemText, null, onClick, itemText));
            }
            return owner;
        }
    }
}
