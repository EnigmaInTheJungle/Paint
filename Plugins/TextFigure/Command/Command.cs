using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFigurePlugin.Command
{
    public class Command
    {
        public FigureActions.ActionChangeColor ChangeColor;
        public FigureActions.ActionChangeType ChangeType;
        public FigureActions.ActionChangeWidth ChangeWidth;
        public Data Data { get; set; }


        public Command()
        {
            Data = new Data();
            ChangeColor = new FigureActions.ActionChangeColor(this);
            ChangeType = new FigureActions.ActionChangeType(this);
            ChangeWidth = new FigureActions.ActionChangeWidth(this);
        }

    }
}
