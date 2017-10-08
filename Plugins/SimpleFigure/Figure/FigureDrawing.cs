
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using static SimpleFigurePlugin.Data;

namespace SimpleFigure.Figure.Control
{
    public class FigureDrawing
    {
        private Figure _figure;
        private FigureControl _cfigure;

        public FigureDrawing(FigureControl cfigure)
        {
            _figure = cfigure.Figure;
            _cfigure = cfigure;
        }

        public void DrawFigure(Graphics graphic)
        {
            Pen figurePen = new Pen(_figure.Color, _figure.StrokeWidth);
            Rectangle drawRect = new Rectangle(new Point(_figure.StrokeWidth / 2, _figure.StrokeWidth / 2), _figure.Size);
            _cfigure.Size = new Size(_figure.Size.Width + _figure.StrokeWidth, _figure.Size.Height + _figure.StrokeWidth);

            graphic.SmoothingMode = SmoothingMode.AntiAlias;
            graphic.DrawPath(figurePen, GetFigureShape(drawRect));
        }

        private GraphicsPath GetFigureShape(Rectangle drawClip)
        {
            GraphicsPath shape = new GraphicsPath();
            switch (_figure.Type)
            {
                case FType.Rectangle: shape.AddRectangle(drawClip); break;
                case FType.RRectangle: shape.AddPath(GetRRectanglePath(drawClip), true); break;
                case FType.Ellipse: shape.AddEllipse(drawClip); break;
                case FType.Line: shape.AddPath(GetLinePath(), true); break;
            }
            return shape;
        }
        private GraphicsPath GetLinePath()
        {
            GraphicsPath line = new GraphicsPath();

            Point topLeft = new Point(Math.Min(_figure.Start.X, _figure.End.X), Math.Min(_figure.Start.Y, _figure.End.Y));

            Point startLine = new Point(_figure.Start.X - topLeft.X, _figure.Start.Y - topLeft.Y);
            Point endLine = new Point(_figure.End.X - topLeft.X, _figure.End.Y - topLeft.Y);

            line.AddLine(startLine, endLine);

            return line;
        }
        private GraphicsPath GetRRectanglePath(Rectangle drawClip)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = 20;

            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(drawClip.Location, size);

            path.AddArc(arc, 180, 90);
            arc.X = drawClip.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = drawClip.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = drawClip.Left;
            path.AddArc(arc, 90, 90);
            arc.Y = drawClip.Top;
            path.CloseFigure();

            return path;
        }
     
    }
}
