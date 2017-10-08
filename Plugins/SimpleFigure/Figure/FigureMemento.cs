
using SimpleFigurePlugin;
using System;
using System.Drawing;
using static SimpleFigurePlugin.Data;

namespace SimpleFigure.Figure.Control.Memento
{
    [Serializable()]
    public class FigureMemento
    {
        public int X1 { get; set; }
        public int Y1 { get;  set; }
        public int X2 { get;  set; }
        public int Y2 { get;  set; }
        public int Color { get;  set; }
        public int Width { get;  set; }
        public int Type { get;  set; }

        public string Text { get; set; }
        public int TextColor { get; set; }
        public string FontFamily { get; set; }
        public float TextSize { get; set; }
        public float TextAngle { get; set; }
        public int TextAlignment { get; set; }

        public string PageName { get; set; }

        public FigureMemento(FigureControl cfigure)
        {
            Figure figure = cfigure.Figure;

            X1 = figure.Start.X;
            Y1 = figure.Start.Y;
            X2 = figure.End.X;
            Y2 = figure.End.Y;
            Color = figure.Color.ToArgb();
            Width = figure.StrokeWidth;
            Type = (int)figure.Type;

            //PageName = (cfigure.Parent.Parent as Page).Text;
        }

        public FigureMemento()
        {

        }

        public Figure GetState()
        {
            Data data = new Data();

            data.Color = System.Drawing.Color.FromArgb(Color);
            data.StrokeWidth = Width;
            data.Type = (FType)Type;

            Figure figure = new Figure(new Point(X1, Y1), new Point(X2, Y2), data);
            return figure;
        }
    }
}
