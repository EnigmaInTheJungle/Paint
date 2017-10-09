
using System;
using System.Collections.Generic;
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
            alignStrip = GetDropDownStrip("Alignment", new List<string>() { "Top", "o Center", "Bottom","Left","o Center","Right" });
            rotateStrip = GetDropDownStrip("Rotate Text", new List<string>() { "45 deg. turn to right", "45 deg. turn to left" });
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
