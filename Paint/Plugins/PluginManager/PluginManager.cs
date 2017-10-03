using Paint.Command;
using Paint.Plugins.SimpleFigurePlugin;
using Paint.Plugins.TextFigurePlugin;
using Paint.UI.Managers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Plugins.Manager
{
    public class PluginManager
    {
        private static IPlugin _activePlugin;
        public static IPlugin ActivePlugin
        {
            get
            {
                return _activePlugin;
            }
            set
            {
                _activePlugin = value;
                if(_activePlugin != null)
                    _command.UpdateData.Action(_activePlugin.GetNewData());
                else
                    _command.UpdateData.Action(null);
            }
        }

        private static XCommand _command;
        public static void SetCommand(XCommand command)
        {
            _command = command;
        }

        public static void ConnectPlugin(string pluginName)
        {
            if(GetPlugin(pluginName) != null)
                PluginPanelManager.AddPluginElement(CreatePluginElement(GetPlugin(pluginName)));           
        }
        public static void RemovePlugin(string pluginName)
        {
            if (GetPlugin(pluginName) != null)
            {
                if (ActivePlugin != null)
                {
                    MenuManager.RemovePluginMenuItems();
                    ToolManager.RemovePluginToolItems(ActivePlugin.GetToolBarItems());
                }
                PluginPanelManager.RemovePluginElement(pluginName);
                ActivePlugin = null;
            }
        }

        public static IPlugin GetPlugin(string pluginName)
        {
            switch (pluginName)
            {
                case "Simple Figure": return new SimpleFigure(_command);
                case "Figure with text": return new TextFigure(_command);
                default: return null;
            }
        }

        public static void SetActivePlugin(string pluginName)
        {
            if (GetPlugin(pluginName) != null)
            {
                if (ActivePlugin != null)
                {
                    MenuManager.RemovePluginMenuItems();
                    ToolManager.RemovePluginToolItems(ActivePlugin.GetToolBarItems());
                }

                ActivePlugin = GetPlugin(pluginName);
                MenuManager.AddPluginMenuItems(GetPlugin(pluginName).GetMenuBarItems());
                ToolManager.AddPluginToolItems(GetPlugin(pluginName).GetToolBarItems());
            }
        }

        private static Button CreatePluginElement(IPlugin plugin)
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
                    MenuManager.RemovePluginMenuItems();
                    ToolManager.RemovePluginToolItems(ActivePlugin.GetToolBarItems());
                }

                ActivePlugin = plugin;
                MenuManager.AddPluginMenuItems(plugin.GetMenuBarItems());
                ToolManager.AddPluginToolItems(plugin.GetToolBarItems());               
            };
            return btn;
        }
    }
}
