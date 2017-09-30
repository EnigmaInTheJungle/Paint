
using Paint.Command.Actions;
using Paint.Data;
using Paint.UI.Frame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Command
{
    public class XCommand
    {
        //public FigureActions.ActionWidth Width;
        //public FigureActions.ActionColor Color;
        //public FigureActions.ActionType Type;

        public FrameActions.ActionSave Save;
        public FrameActions.ActionOpen Open;
        public FrameActions.ActionStatus Status;

        //public TextActions.ActionFont Font;
        //public TextActions.ActionTextAngle TextAngle;
        //public TextActions.ActionTextAlignment TextAlignment;
        //public TextActions.ActionTextColor TextColor;
        //public TextActions.ActionText Text;

        public TabActions.ActionAddPage AddPage;
        public TabActions.ActionRemovePage RemovePage;
        public TabActions.ActionRenamePage RenamePage;
        public TabActions.ActionActiveFigure ActiveFigure;
        public TabActions.ActionSelectPage SelectPage;

        Point _point;
        public Point Point
        {
            get
            {
                return _point;
            }
            set
            {
                _point = value;
                OnPointChange(_point);
            }
        }

        public XData Data { get; set; }

        public Frame Frame { get; set; }

        public Action<Point> OnPointChange;
        public Action<XData> OnDataChange;


        public XCommand()
        {

            //Width = new FigureActions.ActionWidth(this);
            //Color = new FigureActions.ActionColor(this);
            //Type = new FigureActions.ActionType(this);

            Save = new FrameActions.ActionSave(this);
            Open = new FrameActions.ActionOpen(this);
            Status = new FrameActions.ActionStatus(this);

            //Font = new TextActions.ActionFont(this);
            //TextAngle = new TextActions.ActionTextAngle(this);
            //TextAlignment = new TextActions.ActionTextAlignment(this);
            //TextColor = new TextActions.ActionTextColor(this);
            //Text = new TextActions.ActionText(this);

            AddPage = new TabActions.ActionAddPage(this);
            RemovePage = new TabActions.ActionRemovePage(this);
            RenamePage = new TabActions.ActionRenamePage(this);
            ActiveFigure = new TabActions.ActionActiveFigure(this);
            SelectPage = new TabActions.ActionSelectPage(this);
        }      

    }
}
