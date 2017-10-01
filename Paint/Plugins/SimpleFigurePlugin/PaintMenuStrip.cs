using Paint.Command;
using Paint.UI.MenuBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Plugins.SimpleFigurePlugin
{
    public class PaintMenuStrip : ToolStripMenuItem
    {
        ToolStripMenuItem colorStrip;
        ToolStripMenuItem widthStrip;
        ToolStripMenuItem freeStrip;
        ToolStripMenuItem lineStrip;
        ToolStripMenuItem rectStrip;
        ToolStripMenuItem ellipseStrip;
        ToolStripMenuItem rrectStrip;

        public PaintMenuStrip(Command.Command command)
        {
            Text = "Paint";
            Name = "Paint";

            colorStrip = new ToolStripMenuItem("Color", null, command.ChangeColor.Action);
            widthStrip = MenuBar.GetDropDownStrip("Width", new List<string>() { "1", "5", "10" }, command.ChangeWidth.Action);
            freeStrip = new ToolStripMenuItem("Free pencil", null, command.ChangeType.Action);
            lineStrip = new ToolStripMenuItem("Line", null, command.ChangeType.Action);
            rectStrip = new ToolStripMenuItem("Rectangle", null, command.ChangeType.Action);
            ellipseStrip = new ToolStripMenuItem("Ellipse", null, command.ChangeType.Action);
            rrectStrip = new ToolStripMenuItem("Rounded Rectangle", null, command.ChangeType.Action);

            DropDownItems.Add(colorStrip);
            DropDownItems.Add(widthStrip);
            DropDownItems.Add(new ToolStripSeparator());

            DropDownItems.Add(freeStrip);
            DropDownItems.Add(lineStrip);
            DropDownItems.Add(rectStrip);
            DropDownItems.Add(ellipseStrip);
            DropDownItems.Add(rrectStrip);

        }
    }
}
