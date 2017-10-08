using Points;
using System.Drawing;
using static SimpleFigure.Figure.Control.FigureControl;

namespace SimpleFigure.Figure.Control
{
    public class FigureTransform
    {
        private FigureControl _cfigure;

        public FigureTransform(FigureControl fc)
        {
            _cfigure = fc;
        }

        public void Move(Point start, Point end)
        {
            int deltaX = end.X - start.X;
            int deltaY = end.Y - start.Y;

            Update(new Point(_cfigure.Figure.Start.X + deltaX, _cfigure.Figure.Start.Y + deltaY),
                   new Point(_cfigure.Figure.End.X + deltaX, _cfigure.Figure.End.Y + deltaY));
        }
        public Side Resize(Point point, Side side)
        {
            Figure figure = _cfigure.Figure;

            Point resizedPoint = new Point(figure.Start.X + point.X, figure.Start.Y + point.Y);

            int x1 = figure.Start.X;
            int y1 = figure.Start.Y;
            int x2 = figure.End.X;
            int y2 = figure.End.Y;

            if (side == Side.top)
            {
                y1 = resizedPoint.Y;
                if (y1 > y2)
                    side = Side.bot;
            }
            else if (side == Side.topRight)
            {
                y1 = resizedPoint.Y;
                x2 = resizedPoint.X;
                if (y1 > y2)
                    side = Side.botRight;
                else if (x2 < x1)
                    side = Side.topLeft;
            }
            else if (side == Side.right)
            {
                x2 = resizedPoint.X;
                if (x2 < x1)
                    side = Side.left;
            }
            else if (side == Side.botRight || side == Side.endLine)
            {
                x2 = resizedPoint.X;
                y2 = resizedPoint.Y;
                if (y2 < y1 && side != Side.endLine)
                    side = Side.topRight;
                else if (x2 < x1 && side != Side.endLine)
                    side = Side.botLeft;
            }
            else if (side == Side.bot)
            {
                y2 = resizedPoint.Y;
                if (y2 < y1)
                    side = Side.top;
            }
            else if (side == Side.botLeft)
            {
                x1 = resizedPoint.X;
                y2 = resizedPoint.Y;
                if (y2 < y1)
                    side = Side.topLeft;
                else if (x1 > x2)
                    side = Side.botRight;
            }
            else if (side == Side.left)
            {
                x1 = resizedPoint.X;
                if (x1 > x2)
                    side = Side.right;
            }
            else if (side == Side.topLeft || side == Side.startLine)
            {
                x1 = resizedPoint.X;
                y1 = resizedPoint.Y;
                if (y1 > y2 && side != Side.startLine)
                    side = Side.botLeft;
                else if (x1 > x2 && side != Side.startLine)
                    side = Side.topRight;
            }

            Point start = new Point(x1, y1);
            Point end = new Point(x2, y2);

            Update(FPoint.TopLeft(start, end), FPoint.BotRight(start, end));

            return side;
        }

        private void Update(Point start, Point end)
        {
            Figure figure = _cfigure.Figure;

            _cfigure.Figure.Update(start,end);
            _cfigure.SetLocation();
        }
    }
}
