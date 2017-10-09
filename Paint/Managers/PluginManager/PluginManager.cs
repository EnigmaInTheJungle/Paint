using Paint.Command;
using PluginInterface;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Paint.Managers
{
    public class PluginManager
    {
        public ICollection<IPlugin> Plugins;
        public XCommand Command { get; set; }

        private static PluginManager instance = new PluginManager();
        private PluginManager()
        {
        }
        public static PluginManager GetInstance()
        {
            return instance;
        }

        public void LoadPlugins(string path = @"E:\ORT_1708\Team\Paint\Plugins")
        {
            Plugins = PluginLoader.LoadPlugins(path);
        }

        public IPlugin GetPluginByName(string pluginName)
        {
            return Plugins.First(x => x.Name == pluginName);
        }

        public Button CreatePluginElement(string pluginName)
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
                    Command.SetActivePlugin.Action(plugin);
                };
                return btn;
        }
    }
}
