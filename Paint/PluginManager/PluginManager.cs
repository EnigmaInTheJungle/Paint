using Paint.Command;
using Paint.Data;
using Paint.Plugins.PluginManager;
using Paint.UI.Managers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Plugins.Manager
{
    public class PluginManager
    {
        public static ICollection<IPlugin> Plugins;

        public static void LoadPlugins(string path = @"E:\ORT_1708\Team\Paint\Plugins")
        {
            Plugins = PluginLoader.LoadPlugins(path);
        }

        public static XCommand Command => _command;
        private static XCommand _command;
        public static void SetCommand(XCommand command)
        {
            _command = command;
        }


        public static IPlugin GetPluginByName(string pluginName)
        {
            return Plugins.First(x => x.Name == pluginName);
        }
        public static Button CreatePluginElement(string pluginName)
        {
            if (GetPluginByName(pluginName) != null)
            {
                IPlugin plugin = GetPluginByName(pluginName);
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
                    _command.SetActivePlugin.Action(plugin);
                };
                return btn;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
