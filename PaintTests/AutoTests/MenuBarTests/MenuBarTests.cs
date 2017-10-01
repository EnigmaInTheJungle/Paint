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

namespace PaintTests.AutoTests
{
    [TestFixture]
    public class MenuBarTests
    {
        Window window = null;
        [SetUp]
        public void StartUp()
        {
            Application application = Application.Launch(POM.AppPath);
            window = application.GetWindow(POM.WindowName, InitializeOption.NoCache);
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
            List<Menu> menues = new List<Menu> { POM.MenuBar.SExitMenu, POM.MenuBar.SLoadCloudMenu, POM.MenuBar.SNewMenu, POM.MenuBar.SOpenMenu,
                POM.MenuBar.SSaveAsMenu,POM.MenuBar.SSaveCloudMenu ,POM.MenuBar.SSaveMenu  };
            foreach (Menu menu in menues)
            {
                Assert.AreEqual(true, menu.Enabled);
            }
        }

        [TearDown]
        public void TearDown()
        {
            window.Close();
        }
    }
}


