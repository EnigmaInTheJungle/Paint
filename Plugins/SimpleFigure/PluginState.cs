using System.Windows.Forms;
using SimpleFigure.Figure.Control;
using PluginInterface;
using System;

namespace SimpleFigurePlugin
{
    class PluginContext : IPluginContext
    {
        public IData Data { get; set; }
        public IFigureView ActiveFigure { get => Command.Command.ActiveFigure; set => Command.Command.ActiveFigure = value as FigureControl; }
        public IPlugin Plugin { get; set; }

        public PluginContext()
        {

        }

        public PluginContext(IData data, IFigureView activeFigure, IPlugin plugin)
        {
            Data = data;
            ActiveFigure = activeFigure;
            Plugin = plugin;
        }

        internal IPluginContext GetNewContext(SimpleFigure simpleFigure)
        {
            return new PluginContext(new Data(), null, simpleFigure);
        }
    }
}
