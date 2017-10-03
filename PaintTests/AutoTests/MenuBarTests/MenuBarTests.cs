using System;
using NUnit.Framework;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.ListViewItems;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using System.Collections.Generic;
//using System.Windows.Forms;
using Paint.UI.Bars;
using PaintTests.AutoTest.Command;
using System.Diagnostics;

namespace PaintTests.AutoTests
{
    [TestFixture]
    public class MenuBarTest
    {
        Window window = null;
        [SetUp]
        public void StartUp()
        {
            Application application = Application.Launch(@"E:\ORT_1708\Team\Paint\TestFormCreator\bin\Debug\MenuTest");
            window = application.GetWindow("Form1", InitializeOption.NoCache);
            POM.Window = window;
        }

        [Test]
        public void TestExistMenuBar()
        {
            List<Menu> menues = new List<Menu> { POM.MenuBar.FileMenu, POM.MenuBar.WindowMenu, POM.MenuBar.ViewMenu, POM.MenuBar.HelpMenu,
                POM.MenuBar.SettingsMenu };
            foreach (Menu menu in menues)
            {
                Assert.AreEqual(true, menu.Enabled);
            }
        }

        [Test]
        public void TestFileMenu()
        {
            TestMenuClick(POM.MenuBar.SNewMenu, "AddPage");
            TestMenuClick(POM.MenuBar.SOpenMenu, "Open");
            TestMenuClick(POM.MenuBar.SSaveMenu, "Save");
            TestMenuClick(POM.MenuBar.SSaveAsMenu, "SaveAs");
            TestMenuClick(POM.MenuBar.SSaveCloudMenu, "SaveCloud");
            TestMenuClick(POM.MenuBar.SLoadCloudMenu, "LoadCloud");
        }

        [Test]
        public void TestViewMenu()
        {
            //TestMenuClick(POM.MenuBar.SToolBarMenu, "ToolBar");
            //TestMenuClick(POM.MenuBar.SToolBoxMenu, "ToolBox");
            TestMenuClick(POM.MenuBar.SDarkMenu, "ChangeSkin");
            TestMenuClick(POM.MenuBar.SLightMenu, "ChangeSkin");
            TestMenuClick(POM.MenuBar.SPinkMenu, "ChangeSkin");
        }

        [Test]
        public void TestSettingsMenu()
        {
            TestMenuClick(POM.MenuBar.STextFigMenu, "RemovePlugin");
            TestMenuClick(POM.MenuBar.SSimpleFigMenu, "RemovePlugin");
            TestMenuClick(POM.MenuBar.SEngMenu, "Lang");
            TestMenuClick(POM.MenuBar.SUkrMenu, "Lang");
            TestMenuClick(POM.MenuBar.SRusMenu, "Lang");
        }

        [Test]
        public void TestWindowMenu()
        {
            TestMenuClick(POM.MenuBar.SRenameMenu, "RenamePage");
            TestMenuClick(POM.MenuBar.SCloseMenu, "RemovePage");
            TestMenuClick(POM.MenuBar.SCloseAllMenu, "RemoveAllPages");
        }

        private void TestMenuClick(Menu menu, string result)
        {
            menu.Click();
            
            if (window.GetElement(SearchCriteria.ByText(result)).Current.Name == result)
                window.Get<Button>(SearchCriteria.ByText("OK")).Click();
        }

        [TearDown]
        public void TearDown()
        {
            window.Close();
        }
    }
}


