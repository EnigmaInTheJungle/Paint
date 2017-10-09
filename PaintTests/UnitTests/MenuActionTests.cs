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
    public class MenuActionTests
    {
        UCommand ucommand;
        MenuBar menuBar;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            
        }

        [SetUp]
        public void SetUp()
        {
            ucommand = new UCommand();
            menuBar = new MenuBar(ucommand);
        }

        [TestCase("New", "AddPage")]
        [TestCase("Open", "Open")]
        [TestCase("Save", "Save")]
        [TestCase("Save as..", "SaveAs")]
        [TestCase("Save in Cloud", "SaveCloud")]
        [TestCase("Load from Cloud", "LoadCloud")]
        public void TestFileMenuActions(string name, string result)
        {
            ToolStripMenuItem fileItem = menuBar.Items["File"] as ToolStripMenuItem;
            fileItem.DropDownItems[name].PerformClick();
            Assert.AreEqual(result, ucommand.Result);
        }


        [TestCase("Rename", "RenamePage")]
        [TestCase("Close", "RemovePage")]
        [TestCase("CloseAll", "RemoveAllPages")]
        public void TestWindowMenuActions(string name, string result)
        {
            ToolStripMenuItem fileItem = menuBar.Items["Window"] as ToolStripMenuItem;
            fileItem.DropDownItems[name].PerformClick();
            Assert.AreEqual(result, ucommand.Result);
        }

        [TestCase("Dark", "ChangeSkin")]
        [TestCase("Light", "ChangeSkin")]
        [TestCase("Pink", "ChangeSkin")]
        public void TestViewMenuActions(string name, string result)
        {
            ToolStripMenuItem fileItem = menuBar.Items["View"] as ToolStripMenuItem;
            (fileItem.DropDownItems["Skin"] as ToolStripMenuItem).DropDownItems[name].PerformClick();
            Assert.AreEqual(result, ucommand.Result);
        }

        [TestCase("Russian", "Lang")]
        [TestCase("English", "Lang")]
        [TestCase("Ukrainian", "Lang")]
        public void TestLangMenuActions(string name, string result)
        {
            ToolStripMenuItem fileItem = menuBar.Items["Settings"] as ToolStripMenuItem;
            (fileItem.DropDownItems["Language"] as ToolStripMenuItem).DropDownItems[name].PerformClick();
            Assert.AreEqual(result, ucommand.Result);
        }

        [TestCase("Simple Figure", "RemovePlugin")]
        [TestCase("Figure with text", "RemovePlugin")]
        public void TestPluginMenuActions(string name, string result)
        {
            ToolStripMenuItem fileItem = menuBar.Items["Settings"] as ToolStripMenuItem;
            fileItem.DropDownItems[name].PerformClick();
            Assert.AreEqual(result, ucommand.Result);
        }
    }
}
