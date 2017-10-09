using Paint.Plugins.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paint.Data;
using System.Windows.Forms;
using SimpleFigurePlugin;
using SimpleFigurePlugin.Command;
using SimpleFigure.Figure.Control;

namespace SimpleFigurePlugin
{
    class PluginState : IPluginState
    {
        public IData Data { get => _command.Data; }
        public Control ActiveFigure { get => Command.Command.ActiveFigure;
                                            set => Command.Command.ActiveFigure = value as FigureControl; }

        Command.Command _command;

        public PluginState(Command.Command command)
        {
            _command = command;

            _command.Data = new Data();
            Command.Command.ActiveFigure = null;
        }
    }
}
