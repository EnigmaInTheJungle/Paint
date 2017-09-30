
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Command.Actions
{
    public static class TextActions
    {
        public class ActionFont
        {
            XCommand cmd;
            public ActionFont(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(Font font)
            {
                FigureControl figure = cmd.Frame.Tab.ActiveFigure;
                if (figure != null)
                    figure.SetTextFont(font);
            }
        }
        public class ActionTextColor
        {
            XCommand cmd;
            public ActionTextColor(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(Color color)
            {
                FigureControl figure = cmd.Frame.Tab.ActiveFigure;
                if (figure != null)
                    figure.SetTextColor(color);
            }
        }
        public class ActionTextAlignment
        {
            XCommand cmd;
            public ActionTextAlignment(XCommand cmd)
            {
                this.cmd = cmd;
            }

            public void Action(string align)
            {
                FigureControl figure = cmd.Frame.Tab.ActiveFigure;               
                if (figure != null)
                {
                    ContentAlignment cAlign = ContentAlignment.MiddleCenter;
                    switch (align)
                    {
                        case "Top Left": cAlign = ContentAlignment.TopLeft; break;
                        case "Top": cAlign = ContentAlignment.TopCenter; break;
                        case "Top Right": cAlign = ContentAlignment.TopRight; break;
                        case "Left": cAlign = ContentAlignment.MiddleLeft; break;
                        case "Center": cAlign = ContentAlignment.MiddleCenter; break;
                        case "Right": cAlign = ContentAlignment.MiddleRight; break;
                        case "Bot Left": cAlign = ContentAlignment.BottomLeft; break;
                        case "Bot": cAlign = ContentAlignment.BottomCenter; break;
                        case "Bot Right": cAlign = ContentAlignment.BottomRight; break;
                    }
                    figure.SetTextAlignment(cAlign);
                }
            }
        }
        public class ActionTextAngle
        {
            XCommand cmd;
            public ActionTextAngle(XCommand cmd)
            {
                this.cmd = cmd;
            }

            public void Action(float angle, bool delta)
            {
                FigureControl figure = cmd.Frame.Tab.ActiveFigure;
                if (figure != null)
                {
                    if (delta)
                        figure.SetTextRotation(figure.Figure.Text.Angle + angle);
                    else
                        figure.SetTextRotation(angle);
                }
            }
        }
        public class ActionText
        {
            XCommand cmd;
            public ActionText(XCommand cmd)
            {
                this.cmd = cmd;
            }

            public void Action(string text)
            {
                FigureControl figure = cmd.Frame.Tab.ActiveFigure;
                if (figure != null)
                    figure.SetText(text);
            }
        }
    }
}
