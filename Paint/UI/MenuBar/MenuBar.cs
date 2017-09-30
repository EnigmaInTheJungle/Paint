using Paint.Command;
using Paint.UI.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.MenuBar
{
    public class MenuBar : MenuStrip
    {
        public static ResourceManager Localization { get; private set; }
        public MenuBar(XCommand command)
        {
            Items.Add(new FileStrip(command));
            Items.Add(new WindowStrip(command));
            Items.Add(new ViewStrip(command));
            Items.Add(new SettingsStrip(command));
            Items.Add(new HelpStrip(command));
            //Localization = new ResourceManager("Paint.Localization.En", Assembly.GetExecutingAssembly());
        }

        public static ToolStripMenuItem GetDropDownStrip(string ownerText, List<string> items, System.EventHandler onClick = null)
        {
            ToolStripMenuItem owner = new ToolStripMenuItem(ownerText, null);
            foreach (string itemText in items)
            {
                owner.DropDownItems.Add(new ToolStripMenuItem(itemText, null, onClick));
            }
            return owner;
        }
    }
}
