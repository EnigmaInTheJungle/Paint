using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Plugins.TextFigurePlugin.Command
{
    public class Command
    {
        public FigureActions.ActionChangeColor ChangeColor;
        public FigureActions.ActionChangeType ChangeType;
        public FigureActions.ActionChangeWidth ChangeWidth;

        public Command(XCommand command)
        {
            ChangeColor = new FigureActions.ActionChangeColor(command);
            ChangeType = new FigureActions.ActionChangeType(command);
            ChangeWidth = new FigureActions.ActionChangeWidth(command);
        }

    }
}
