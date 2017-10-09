using Points;
using SimpleFigurePlugin;
using System;
using System.Drawing;
using static SimpleFigurePlugin.Data;

namespace SimpleFigure.Figure
{
    public class Figure
    {
        public Color Color { get; set; }
        public int StrokeWidth { get; set; }
        public FType Type { get; set; }
        public Point End { get; private set; }
        public Point Start { get; private set; }
        public Size Size { get; private set; }


        public Figure(Point startPoint, Point endPoint, Data data)
        {
            Color = data.Color;
            Type = data.Type;
            StrokeWidth = data.StrokeWidth;
            SetPoints(startPoint, endPoint);
            Size = new Size(Math.Abs(End.X - Start.X), Math.Abs(End.Y - Start.Y));
        }
        public Figure()
        {

        }

        public void Update(Point startPoint, Point endPoint)
        {
            SetPoints(startPoint, endPoint);
            Size = new Size(Math.Abs(startPoint.X - endPoint.X), Math.Abs(startPoint.Y - endPoint.Y));
        }

        private void SetPoints(Point start, Point end)
        {
            if (Type != FType.Line)
            {
                Start = FPoint.TopLeft(start,end);
                End = FPoint.BotRight(start, end);
            }
            else
            {
                Start = start;
                End = end;
            }
        }
    }
}
