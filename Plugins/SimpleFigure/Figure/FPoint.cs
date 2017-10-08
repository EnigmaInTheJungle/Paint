using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    public static class FPoint
    {
        public static Point TopLeft(Point start, Point end)
        {
            return new Point(Math.Min(start.X, end.X), Math.Min(start.Y, end.Y));
        }
        public static Point BotRight(Point start, Point end)
        {
            return new Point(Math.Max(start.X, end.X), Math.Max(start.Y, end.Y));
        }
    }
}
