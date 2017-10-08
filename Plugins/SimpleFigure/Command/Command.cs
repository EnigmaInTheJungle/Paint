using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paint.Data;
using SimpleFigure.Figure.Control;

namespace SimpleFigurePlugin.Command
{
    public class Command
    {
        public SimpleFigureActions.ActionChangeColor ChangeColor;
        public SimpleFigureActions.ActionChangeType ChangeType;
        public SimpleFigureActions.ActionChangeWidth ChangeWidth;

        public Data Data { get; set; }
        public static FigureControl ActiveFigure { get; internal set; }

        public Command()
        {
            ActiveFigure = null;
            Data = new Data();
            ChangeColor = new SimpleFigureActions.ActionChangeColor(this);
            ChangeType = new SimpleFigureActions.ActionChangeType(this);
            ChangeWidth = new SimpleFigureActions.ActionChangeWidth(this);
        }
    }
}
