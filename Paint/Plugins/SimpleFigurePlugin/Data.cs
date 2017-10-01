using Paint.Data;
using System.Drawing;

namespace Paint.Plugins.SimpleFigurePlugin
{
    public class Data : IData
    {
        public enum FType {Curve, Rectangle, Ellipse, RRectangle, Line }

        public FType Type { get; set; }
        public Color Color { get; set; }
        public int StrokeWidth { get; set; }

        public Data()
        {
            Type = FType.Curve;
            Color = Color.Black;
            StrokeWidth = 1;
        }

        public Data(Data data)
        {
            Type = data.Type;
            Color = data.Color;
            StrokeWidth = data.StrokeWidth;
        }
    }
}
