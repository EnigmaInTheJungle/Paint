using Paint.Command;
using Paint.Managers;
using Paint.UI.Menu;
using Paint.UI.Tab;
using Paint.UI.ToolBox;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Paint.UI.Frame
{
    public class Frame : Panel
    {
        public MenuBar MenuBar { get; }
        public LeftToolBox LeftToolBox { get; }
        public Tabs Tabs { get; }
        public Tool.ToolBar ToolBar { get; }
        public StatusBar StatusBar { get; }


        public Frame()
        {
            Dock = DockStyle.Fill;

            XCommand command = new XCommand();
            command.Frame = this;

            PluginManager plgManager = PluginManager.GetInstance();
            plgManager.Command = command;
            plgManager.LoadPlugins();

            SkinManager sknManager = SkinManager.GetInstance();
            sknManager.LoadSkins();

            MenuBar = new MenuBar(command);
            LeftToolBox = new LeftToolBox(command);
            Tabs = new Tabs(command);
            ToolBar = new Tool.ToolBar(command);
            StatusBar = new StatusBar();

            
            MenuBar.AddPluginsToMenu(plgManager.Plugins);
            MenuBar.AddSkinsToMenu(sknManager.Skins);

            Controls.Add(Tabs);
            Controls.Add(LeftToolBox);
            Controls.Add(ToolBar);
            Controls.Add(MenuBar);
            Controls.Add(StatusBar);

            command.AddPage.Action(this, new EventArgs());
            command.SetActivePlugin.Action(plgManager.Plugins.First());
        }
    }
}
