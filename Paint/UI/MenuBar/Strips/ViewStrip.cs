using Paint.Command;
using Paint.Managers;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SkinInterface;
using System;

namespace Paint.UI.Menu.Strips
{
    class ViewStrip : ToolStripMenuItem
    {
        ToolStripMenuItem toolBoxStrip;
        ToolStripMenuItem toolBarStrip;
        ToolStripMenuItem skinStrip;

        ICommand _command;

        public ViewStrip(ICommand command)
        {
            _command = command;

            LanguageManager langMang = LanguageManager.GetInstance();
            Name = "View";
            Text = langMang.GetValue(Name);

            toolBoxStrip = new ToolStripMenuItem(langMang.GetValue("ToolBox"), null,null, "ToolBox");
            toolBarStrip = new ToolStripMenuItem(langMang.GetValue("ToolBar"), null,null, "ToolBar");
       
            toolBoxStrip.CheckState = CheckState.Checked;
            toolBarStrip.CheckState = CheckState.Checked;

            DropDownItems.Add(toolBoxStrip);
            DropDownItems.Add(toolBarStrip);
            DropDownItems.Add(new ToolStripSeparator());

           
        }

        internal void AddSkinsToMenu(List<ISkin> skins)
        {
            skinStrip = MenuBar.GetDropDownStrip("Skins", skins.Select(x => x.Name).ToList(), _command.ChangeSkin.Action);
            DropDownItems.Add(skinStrip);
        }
    }
}
