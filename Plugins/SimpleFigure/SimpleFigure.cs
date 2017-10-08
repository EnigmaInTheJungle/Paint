using Paint.Command;
using Paint.Data;
using Paint.Plugins;
using SimpleFigure.Figure.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SimpleFigure.Figure;

namespace SimpleFigurePlugin
{
    class SimpleFigure : IPlugin
    {
        public string Name => "Simple Figure";

        public Control ActiveFigure => Command.Command.ActiveFigure;

        Command.Command command;

        public SimpleFigure()
        {
            command = new Command.Command();
        }

        public List<ToolStripMenuItem> GetMenuBarItems()
        {
            return new List<ToolStripMenuItem>() { new FigureMenuStrip(command) };
        }
        public UserControl GetPropertyEditor()
        {
            throw new NotImplementedException();
        }
        public ToolStripItem[] GetToolBarItems()
        {
            FigureToolStrip paintStrip = new FigureToolStrip(command);
            return paintStrip.StripList;
        }

        public IData GetNewData()
        {
            command.Data = new Data();
            Command.Command.ActiveFigure = null;
            return command.Data;
        }
        public Control GetNewFigure(Point start, Point end, IData data)
        {
            return new FigureControl(new Figure(start, end, (data as Data)));
        }
    }
}
