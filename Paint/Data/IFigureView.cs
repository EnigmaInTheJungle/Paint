using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Data
{
    public interface IFigureView
    {
        Control NewFigure(Point start, Point end, IData data);
    }
}
