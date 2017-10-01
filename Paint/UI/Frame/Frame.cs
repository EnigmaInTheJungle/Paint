using Paint.Command;
using Paint.Plugins.SimpleFigurePlugin;
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
        public MenuBar.MenuBar MenuBar;
        public DrawFigureType.DrawFigureType DrawFigureType;
        public Tabs.Tabs Tabs;
        public ToolBar.ToolBar ToolBar;
        public StatusBar.StatusBar StatusBar;


        public Frame()
        {
            Dock = DockStyle.Fill;

            XCommand command = new XCommand();
            command.Frame = this;

            MenuBar = new MenuBar.MenuBar(command);
            DrawFigureType = new UI.DrawFigureType.DrawFigureType(command);
            Tabs = new UI.Tabs.Tabs(command);
            ToolBar = new UI.ToolBar.ToolBar(command);
            StatusBar = new UI.StatusBar.StatusBar(command);

            Controls.Add(Tabs);

            Controls.Add(DrawFigureType);
            Controls.Add(ToolBar);
            Controls.Add(MenuBar);
            Controls.Add(StatusBar);
        }
    }
}
