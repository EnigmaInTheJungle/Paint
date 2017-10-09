using Paint.Command;
using Paint.Plugins.Manager;
using Paint.UI.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.Frame
{
    public class Frame : Panel
    {
        public Bars.MenuBar MenuBar;
        public Panels.PluginPanel PluginPanel;
        public Tabs.Tabs Tabs;
        public Bars.ToolBar ToolBar;
        public Bars.StatusBar StatusBar;
        

        public Frame()
        {
            Dock = DockStyle.Fill;

            XCommand command = new XCommand();

            MenuBar = new Bars.MenuBar(command);
            PluginPanel = new Panels.PluginPanel(command);
            Tabs = new Tabs.Tabs(command);
            ToolBar = new Bars.ToolBar(command);
            StatusBar = new Bars.StatusBar(command);

            ToolManager.SetToolBar(ToolBar);
            MenuManager.SetMenuBar(MenuBar);
            TabsManager.SetTabs(Tabs);
            PluginManager.LoadPlugins();
            PluginManager.SetCommand(command);
            PluginPanelManager.SetPluginPanel(PluginPanel);
            MenuManager.AddPluginsToMenu(PluginManager.Plugins);

            Controls.Add(Tabs);
            Controls.Add(PluginPanel);
            Controls.Add(ToolBar);
            Controls.Add(MenuBar);
            Controls.Add(StatusBar);

            command.AddPage.Action(this, new EventArgs());

            //PluginManager.SetActivePlugin("Figure with text");
        }
    }
}
