using Paint.Command;
using Paint.UI.Managers;
using Paint.UI.MenuBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFigurePlugin
{
    public class TextMenuStrip : ToolStripMenuItem
    {
        ToolStripMenuItem textStrip;
        ToolStripMenuItem fontStrip;

        ToolStripMenuItem colorStrip;
        ToolStripMenuItem alignStrip;
        ToolStripMenuItem rotateStrip;
        ToolStripMenuItem clearStrip;

        public TextMenuStrip(Command.Command command)
        {
            Text = "Text";
            Name = "Text";

            colorStrip = new ToolStripMenuItem("Text Color", null);
            alignStrip = MenuManager.GetDropDownStrip("Alignment", new List<string>() { "Top", "o Center", "Bottom","Left","o Center","Right" });
            rotateStrip = MenuManager.GetDropDownStrip("Rotate Text", new List<string>() { "45 deg. turn to right", "45 deg. turn to left" });
            textStrip = new ToolStripMenuItem("Enter Text", null);
            fontStrip = new ToolStripMenuItem("Font", null);
            clearStrip = new ToolStripMenuItem("Clear Text", null);

            DropDownItems.Add(textStrip);
            DropDownItems.Add(new ToolStripSeparator());

            DropDownItems.Add(fontStrip);
            DropDownItems.Add(colorStrip);
            DropDownItems.Add(new ToolStripSeparator());

            DropDownItems.Add(alignStrip);
            DropDownItems.Add(new ToolStripSeparator());

            DropDownItems.Add(rotateStrip);
            DropDownItems.Add(clearStrip);

        }
    }
}
