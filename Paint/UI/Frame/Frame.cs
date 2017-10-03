using Paint.Command;
using Paint.Plugins.Manager;
using Paint.Plugins.SimpleFigurePlugin;
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
            command.Frame = this;

            MenuBar = new Bars.MenuBar(command);
            PluginPanel = new Panels.PluginPanel(command);
            Tabs = new Tabs.Tabs(command);
            ToolBar = new Bars.ToolBar(command);
            StatusBar = new Bars.StatusBar(command);

            ToolManager.SetToolBar(ToolBar);
            MenuManager.SetMenuBar(MenuBar);
            TabsManager.SetTabs(Tabs);
            PluginManager.SetCommand(command);
            PluginPanelManager.SetPluginPanel(PluginPanel);

            Controls.Add(Tabs);
            Controls.Add(PluginPanel);
            Controls.Add(ToolBar);
            Controls.Add(MenuBar);
            Controls.Add(StatusBar);

            TabsManager.AddPage();
            PluginManager.ConnectPlugin("Simple Figure");
            PluginManager.ConnectPlugin("Figure with text");
            PluginManager.SetActivePlugin("Figure with text");
        }
    }
}
