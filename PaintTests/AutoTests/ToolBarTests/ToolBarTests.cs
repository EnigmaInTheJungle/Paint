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
    public class ToolBarTests
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
        public void TestExistToolBar()
        {
            List<Button> tools = new List<Button> { POM.ToolBar.LoadCloudTool, POM.ToolBar.LoadTool, POM.ToolBar.SaveCloudTool, POM.ToolBar.SaveTool};

            foreach (Button btn in tools)
            {
                Assert.AreEqual(true, btn.Enabled);
            }
        }

        [TearDown]
        public void TearDown()
        {
            window.Close();
        }
    }
}


