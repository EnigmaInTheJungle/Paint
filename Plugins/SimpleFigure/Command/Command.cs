using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFigurePlugin.Command
{
    public class Command
    {
        public SimpleFigureActions.ActionChangeColor ChangeColor;
        public SimpleFigureActions.ActionChangeType ChangeType;
        public SimpleFigureActions.ActionChangeWidth ChangeWidth;
        public Data Data { get; set; }


        public Command()
        {
            Data = new Data();
            ChangeColor = new SimpleFigureActions.ActionChangeColor(this);
            ChangeType = new SimpleFigureActions.ActionChangeType(this);
            ChangeWidth = new SimpleFigureActions.ActionChangeWidth(this);
        }

    }
}
