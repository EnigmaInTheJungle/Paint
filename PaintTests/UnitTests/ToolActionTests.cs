using System;
using NUnit.Framework;
using System.Drawing;
using Paint.Command;
using Paint.UI.Frame;
using PaintTests.UnitTest.Command;
using Paint.UI.Menu;
using System.Windows.Forms;

namespace Tests
{
    [TestFixture]
    public class ToolActionTests
    {
        UCommand ucommand;
        Paint.UI.Tool.ToolBar toolBar;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            
        }

        [SetUp]
        public void SetUp()
        {
            ucommand = new UCommand();
            toolBar = new Paint.UI.Tool.ToolBar(ucommand);
        }

        [TestCase("Save", "Save")]
        [TestCase("Open", "Open")]
        public void TestFileToolActions(string name, string result)
        {
            toolBar.Items[name].PerformClick();
            Assert.AreEqual(result, ucommand.Result);
        }


        [TestCase("New File", "AddPage")]
        [TestCase("Close Tab", "RemovePage")]
        [TestCase("Close All Tabs", "RemoveAllPages")]
        public void TestTabToolActions(string name, string result)
        {
            toolBar.Items[name].PerformClick();
            Assert.AreEqual(result, ucommand.Result);
        }

        [TestCase("Save Cloud", "SaveCloud")]
        [TestCase("Load Cloud", "LoadCloud")]
        public void TestCloudToolActions(string name, string result)
        {
            toolBar.Items[name].PerformClick();
            Assert.AreEqual(result, ucommand.Result);
        }
    }
}
