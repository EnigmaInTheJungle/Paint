using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Paint.Command.Actions
{
    public static class FigureActions
    {
        public class ActionWidth
        {
            XCommand cmd;
            public ActionWidth(XCommand cmd)
            {
                this.cmd = cmd;              
            }
            public void Action(int width)
            {
                FigureControl figure = cmd.Frame.Tab.ActiveFigure;
                if (figure == null)
                {
                    XData data = cmd.Data;
                    data.StrokeWidth = width;
                    cmd.Data = data;
                }
                else
                {
                    figure.SetStrokeWidth(width);
                }
            }
        }
        public class ActionColor
        {
            XCommand cmd;
            public ActionColor(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(Color color)
            {
                FigureControl figure = cmd.Frame.Tab.ActiveFigure;
                if (figure == null)
                {
                    XData data = cmd.Data;
                    data.Color = color;
                    cmd.Data = data;
                }
                else
                {
                    figure.SetFigureColor(color);
                }
            }
        }
        public class ActionType
        {
            XCommand cmd;
            public ActionType(XCommand cmd)
            {
                this.cmd = cmd;
            }

            public void Action(string type)
            {
                FigureControl figure = cmd.Frame.Tab.ActiveFigure;              
                if (figure == null)
                {
                    XData data = cmd.Data;                  
                    switch (type)
                    {
                        case "Curve": data.Type = FType.Curve; break;
                        case "Rectangle": data.Type = FType.Rectangle; break;
                        case "RRectangle": data.Type = FType.RRectangle; break;
                        case "Ellipse": data.Type = FType.Ellipse; break;
                        case "Line": data.Type = FType.Line; break;
                    }
                    cmd.Data = data;
                }
                else
                {
                    FType ftype = FType.Rectangle;
                    switch (type)
                    {
                        case "Rectangle": ftype = FType.Rectangle; break;
                        case "RRectangle": ftype = FType.RRectangle; break;
                        case "Ellipse": ftype = FType.Ellipse; break;
                        case "Line": ftype = FType.Line; break;
                    }
                    figure.SetFigureType(ftype);
                }
            }
        }
    }
}
