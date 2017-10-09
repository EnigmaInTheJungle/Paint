using SimpleFigure.Figure.Control;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using SimpleFigure.Figure;
using PluginInterface;

namespace SimpleFigurePlugin
{
    class SimpleFigure : IPlugin
    {
        public string Name => "Simple Figure";

        private PluginContext _context;
        Command.Command _command;

        public IPluginContext GetNewContext { get { return _context.GetNewContext(this); } }
        public IPluginContext SetContext
        {
            set
            {
                _command.Data = value.Data as Data;
                Command.Command.ActiveFigure = value.ActiveFigure as FigureControl;
            }
        }

        public IFigureView FigureView(Point start, Point end, IData data)
        {
            return new FigureControl(new Figure(start, end, data as Data));
        }

       
        public SimpleFigure()
        {
            _command = new Command.Command();
            _context = new PluginContext();
        }

        public List<ToolStripMenuItem> GetMenuBarItems()
        {
            return new List<ToolStripMenuItem>() { new FigureMenuStrip(_command) };
        }
        public UserControl GetPropertyEditor()
        {
            throw new NotImplementedException();
        }
        public ToolStripItem[] GetToolBarItems()
        {
            FigureToolStrip paintStrip = new FigureToolStrip(_command);
            return paintStrip.StripList;
        }
    }

}
