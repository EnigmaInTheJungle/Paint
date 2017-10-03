using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.TabItems;
using TestStack.White.UIItems.ListViewItems;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;

namespace PaintTests.AutoTests
{
    public class POM
    {
        public static Window Window { get; set; }
        public static string AppPath => @"E:\ORT_1708\Team\Paint\Paint\bin\Debug\Paint";
        public static string WindowName => "Form1";

        public static class FigureToolBox
        {
        }

        public static class TextToolBox
        {
        }

        public static class MenuBar
        {
            public static Menu FileMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("File"));
            public static Menu WindowMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("Window"));
            public static Menu ViewMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("View"));
            public static Menu SettingsMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("Settings"));
            public static Menu HelpMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("Help"));

            public static Menu SNewMenu => FileMenu.SubMenu("New");
            public static Menu SOpenMenu => FileMenu.SubMenu("Open");
            public static Menu SSaveMenu => FileMenu.SubMenu("Save");
            public static Menu SSaveAsMenu => FileMenu.SubMenu("Save as..");
            public static Menu SSaveCloudMenu => FileMenu.SubMenu("Save in Cloud");
            public static Menu SLoadCloudMenu => FileMenu.SubMenu("Load from Cloud");

            public static Menu SRenameMenu => WindowMenu.SubMenu("Rename");
            public static Menu SCloseMenu => WindowMenu.SubMenu("Close");
            public static Menu SCloseAllMenu => WindowMenu.SubMenu("CloseAll");

            public static Menu SToolBarMenu => ViewMenu.SubMenu("ToolBar");
            public static Menu SToolBoxMenu => ViewMenu.SubMenu("ToolBox");
            public static Menu SDarkMenu => ViewMenu.SubMenu("Skin").SubMenu("Dark");
            public static Menu SLightMenu => ViewMenu.SubMenu("Skin").SubMenu("Light");
            public static Menu SPinkMenu => ViewMenu.SubMenu("Skin").SubMenu("Pink");

            public static Menu SSimpleFigMenu => SettingsMenu.SubMenu("Simple Figure");
            public static Menu STextFigMenu => SettingsMenu.SubMenu("Figure with text");
            public static Menu SEngMenu => SettingsMenu.SubMenu("Language").SubMenu("English");
            public static Menu SRusMenu => SettingsMenu.SubMenu("Language").SubMenu("Russian");
            public static Menu SUkrMenu => SettingsMenu.SubMenu("Language").SubMenu("Ukrainian");
        }

        public static class ToolBar
        {
            public static Button SaveTool => Window.ToolStrip.Get<Button>(SearchCriteria.ByText("Save"));
            public static Button LoadTool => Window.ToolStrip.Get<Button>(SearchCriteria.ByText("Load"));
            public static Button SaveCloudTool => Window.ToolStrip.Get<Button>(SearchCriteria.ByText("Save Cloud"));
            public static Button LoadCloudTool => Window.ToolStrip.Get<Button>(SearchCriteria.ByText("Load Cloud"));
        }

        public static class Tabs
        {
            public static List<Tab> TabList => Window.Tabs;
            public static int Count => TabList.Find(x => true).TabCount;
            public static ITabPage ActiveTab => TabList.Find(x => true).SelectedTab;           
        }

        public static class StatusBar
        {
            public static UIItem GetLabel(string label)
            {
                return Window.StatusBar(InitializeOption.NoCache).GetLabel(label);
            }
            public static UIItem MousePosLabel => Window.StatusBar(InitializeOption.NoCache).GetLabel("x: y: ");
            public static UIItem PageLabel => Window.StatusBar(InitializeOption.NoCache).GetLabel("PageName");
        }

    }
}
