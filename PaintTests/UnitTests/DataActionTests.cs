using System;
using NUnit.Framework;
using System.Drawing;
using Paint.Command;
using Paint.UI.Frame;
using Paint.Plugins.SimpleFigurePlugin.Command;
using Paint.Plugins.SimpleFigurePlugin;
using static Paint.Plugins.SimpleFigurePlugin.Data;

namespace Tests
{
    [TestFixture]
    public class DataActionTests
    {
        Command command;
        XCommand xcommand;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            xcommand = new XCommand();
            command = new Command(xcommand);
        }

        [SetUp]
        public void SetUp()
        {
            xcommand.Data = new Data();
        }

        [TestCase("Red")]
        [TestCase("Blue")]
        [TestCase("White")]
        public void TestDataColorAction(string color)
        {
        }

        [TestCase("Rectangle", FType.Rectangle)]
        [TestCase("RRectangle", FType.RRectangle)]
        [TestCase("Line", FType.Line)]
        [TestCase("Ellipse", FType.Ellipse)]
        public void TestDataTypeAction(string type, FType ftype)
        {

        }

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(10)]
        public void TestDataStrokeWidthAction(int width)
        {
        }
    }
}
