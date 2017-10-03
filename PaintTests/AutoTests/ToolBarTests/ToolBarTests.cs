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
            Application application = Application.Launch(@"E:\ORT_1708\Team\Paint\TestFormCreator\bin\Debug\ToolTest");
            window = application.GetWindow("Form1", InitializeOption.NoCache);
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

        [Test]
        public void TestCloudToolBar()
        {
            TestToolClick(POM.ToolBar.SaveCloudTool, "SaveCloud");
            TestToolClick(POM.ToolBar.LoadCloudTool, "LoadCloud");
        }

        [Test]
        public void TestFileToolBar()
        {
            TestToolClick(POM.ToolBar.SaveTool, "Save");
            TestToolClick(POM.ToolBar.LoadTool, "Open");
        }

        [Test]
        public void TestTabToolBar()
        {
            TestToolClick(POM.ToolBar.AddPageTool, "AddPage");
            TestToolClick(POM.ToolBar.ClosePageTool, "RemovePage");
            TestToolClick(POM.ToolBar.CloseAllPageTool, "RemoveAllPages");
        }

        private void TestToolClick(Button btn, string result)
        {
            btn.Click();

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


