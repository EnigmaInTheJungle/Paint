using Paint.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.PluginManager
{
    public class PluginManager
    {
        public static IPlugin ActivePlugin { get; private set; }

        public static void ConnectPlugin(IPlugin plugin, XCommand command)
        {
            Button btn = new Button
            {
                Name = plugin.Name,
                Text = plugin.Name,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.WhiteSmoke,
                Height = 40,
                Dock = DockStyle.Top
            };
            btn.Click += (s, e) =>
            {
                if (ActivePlugin != null)
                {
                    command.Frame.MenuBar.RemoveMenuItems(ActivePlugin.GetMenuBarItems());
                    command.Frame.ToolBar.RemoveToolItems(ActivePlugin.GetToolBarItems());
                }

                command.Frame.Tabs.SetNewData(plugin.GetNewData());
                command.Frame.MenuBar.AddMenuItems(plugin.GetMenuBarItems());
                command.Frame.ToolBar.AddToolItems(plugin.GetToolBarItems());
                
                ActivePlugin = plugin;
            };

            command.Frame.DrawFigureType.Controls.Add(btn);           
        }

        public static void RemovePlugin(IPlugin plugin, XCommand command)
        {
            command.Frame.MenuBar.RemoveMenuItems(plugin.GetMenuBarItems());
            command.Frame.ToolBar.RemoveToolItems(ActivePlugin.GetToolBarItems());
            command.Frame.DrawFigureType.Controls.RemoveByKey(plugin.Name);
            ActivePlugin = null;
        }
    }
}
