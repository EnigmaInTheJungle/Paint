using Paint.Command;
using Paint.Managers;
using Paint.UI.Menu.Strips;
using PluginInterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Paint.UI.Menu
{
    public class MenuBar : MenuStrip
    {
        public MenuBar(ICommand command)
        {
            BackColor = Color.White;

            Items.Add(new FileStrip(command));
            Items.Add(new PaintStrip());
            Items.Add(new WindowStrip(command));
            Items.Add(new ViewStrip(command));
            Items.Add(new SettingsStrip(command));
            Items.Add(new HelpStrip(command));
        }

        public static ToolStripMenuItem GetDropDownStrip(string ownerText, List<string> items, EventHandler onClick = null)
        {
            LanguageManager langMang = LanguageManager.GetInstance();

            ToolStripMenuItem owner = new ToolStripMenuItem(langMang.GetValue(ownerText), null, null, ownerText);
            foreach (string itemText in items)
            {
                owner.DropDownItems.Add(new ToolStripMenuItem(langMang.GetValue(itemText), null, onClick, itemText));
            }
            return owner;
        }

        public void AddPluginsToMenu(ICollection<IPlugin> plugins)
        {
            (Items["Settings"] as SettingsStrip).AddPluginsToMenu(plugins);
        }

        public void AddPluginMenuItems(List<ToolStripMenuItem> itemList)
        {
            (Items["Paint"] as PaintStrip).AddPluginMenuItems(itemList);
        }
        public void RemovePluginMenuItems()
        {
            (Items["Paint"] as PaintStrip).RemovePluginMenuItems();
        }

    }
}
