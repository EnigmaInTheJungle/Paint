using Paint.Command;
using Paint.Managers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Paint.UI.Menu.Strips
{
    class ViewStrip : ToolStripMenuItem
    {
        ToolStripMenuItem toolBoxStrip;
        ToolStripMenuItem toolBarStrip;
        ToolStripMenuItem skinStrip;

        public ViewStrip(ICommand command)
        {
            LanguageManager langMang = LanguageManager.GetInstance();
            Name = "View";
            Text = langMang.GetValue(Name);

            toolBoxStrip = new ToolStripMenuItem(langMang.GetValue("ToolBox"), null,null, "ToolBox");
            toolBarStrip = new ToolStripMenuItem(langMang.GetValue("ToolBar"), null,null, "ToolBar");
            skinStrip = MenuBar.GetDropDownStrip("Skin", new List<string>() { "Light", "Dark", "Pink" }, command.ChangeSkin.Action);

            toolBoxStrip.CheckState = CheckState.Checked;
            toolBarStrip.CheckState = CheckState.Checked;

            DropDownItems.Add(toolBoxStrip);
            DropDownItems.Add(toolBarStrip);
            DropDownItems.Add(new ToolStripSeparator());

            DropDownItems.Add(skinStrip);
        }
    }
}
