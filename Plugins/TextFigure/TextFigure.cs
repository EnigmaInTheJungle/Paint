using Paint.Data;
using Paint.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace TextFigurePlugin
{
    class TextFigure : IPlugin
    {
        public string Name => "Figure with text";

        public Control ActiveFigure => throw new NotImplementedException();

        Command.Command command;

        public TextFigure()
        {
            this.command = new Command.Command();
        }

        public List<ToolStripMenuItem> GetMenuBarItems()
        {
            return new List<ToolStripMenuItem>() { new FigureMenuStrip(command) , new TextMenuStrip(command)};
        }

        public UserControl GetPropertyEditor()
        {
            throw new NotImplementedException();
        }

        public ToolStripItem[] GetToolBarItems()
        {
            FigureToolStrip paintStrip = new FigureToolStrip(command);
            TextToolStrip textStrip = new TextToolStrip(command);

            return paintStrip.StripList.Concat(textStrip.StripList).ToArray();
        }

        public IData GetNewData()
        {
            return new Data();
        }

        public Control GetNewFigure(Point start, Point end, IData data)
        {
            throw new NotImplementedException();
        }
    }
}
