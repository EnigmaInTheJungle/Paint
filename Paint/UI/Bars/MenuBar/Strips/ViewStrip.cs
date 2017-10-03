using Paint.Command;
using Paint.UI.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.MenuBar.Strips
{
    class ViewStrip : ToolStripMenuItem
    {
        ToolStripMenuItem toolBoxStrip;
        ToolStripMenuItem toolBarStrip;
        ToolStripMenuItem skinStrip;

        public ViewStrip(ICommand command)
        {
            Text = "View";
            Name = "View";

            toolBoxStrip = new ToolStripMenuItem("ToolBox", null,null, "ToolBox");
            toolBarStrip = new ToolStripMenuItem("ToolBar", null,null, "ToolBar");
            skinStrip = MenuManager.GetDropDownStrip("Skin", new List<string>() { "Light", "Dark", "Pink" }, command.ChangeSkin.Action);

            toolBoxStrip.CheckState = CheckState.Checked;
            toolBarStrip.CheckState = CheckState.Checked;

            DropDownItems.Add(toolBoxStrip);
            DropDownItems.Add(toolBarStrip);
            DropDownItems.Add(new ToolStripSeparator());

            DropDownItems.Add(skinStrip);
        }
    }
}
