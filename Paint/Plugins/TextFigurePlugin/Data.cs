using Paint.Data;
using System.Drawing;

namespace Paint.Plugins.TextFigurePlugin
{
    public class Data : IData
    {
        public enum FType {Rectangle, Ellipse, RRectangle, Line }

        public FType Type { get; set; }
        public Color Color { get; set; }
        public int StrokeWidth { get; set; }

        public Data()
        {
            Type = FType.Rectangle;
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
