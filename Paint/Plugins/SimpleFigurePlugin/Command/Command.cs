using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Plugins.SimpleFigurePlugin.Command
{
    public class Command
    {
        public SimpleFigureActions.ActionChangeColor ChangeColor;
        public SimpleFigureActions.ActionChangeType ChangeType;
        public SimpleFigureActions.ActionChangeWidth ChangeWidth;

        public Command(XCommand command)
        {
            ChangeColor = new SimpleFigureActions.ActionChangeColor(command);
            ChangeType = new SimpleFigureActions.ActionChangeType(command);
            ChangeWidth = new SimpleFigureActions.ActionChangeWidth(command);
        }

    }
}
