using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.MenuBar
{
    class ViewStrip : ToolStripMenuItem
    {
        ToolStripMenuItem toolBoxStrip;
        ToolStripMenuItem toolBarStrip;
        ToolStripMenuItem skinStrip;

        int _pageIndex = 2;

        public ViewStrip(XCommand command)
        {
            Name = "View";

            toolBoxStrip = new ToolStripMenuItem("ToolBox", null, command.RenamePage.Action);
            toolBarStrip = new ToolStripMenuItem("ToolBar", null, command.RemovePage.Action);
            skinStrip = MenuBar.GetDropDownStrip("Skin", new List<string>() { "Light", "Dark", "Pink" });

            toolBoxStrip.CheckState = CheckState.Checked;
            toolBarStrip.CheckState = CheckState.Checked;

            DropDownItems.Add(toolBoxStrip);
            DropDownItems.Add(toolBarStrip);
            DropDownItems.Add(new ToolStripSeparator());

            DropDownItems.Add(skinStrip);
        }
    }
}
