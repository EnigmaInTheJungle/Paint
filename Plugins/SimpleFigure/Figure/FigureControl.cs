using Paint.Data;
using Points;
using SimpleFigure.Figure.Control.Memento;
using SimpleFigurePlugin;
using System;
using System.Drawing;
using System.Windows.Forms;
using static SimpleFigurePlugin.Data;

namespace SimpleFigure.Figure.Control
{
    public partial class FigureControl : UserControl, IFigureView
    {
        public enum Side { left, topLeft, top, topRight, right, botRight, bot, botLeft, none, startLine, endLine, center };

        public Figure Figure { get => _figure; set => _figure = value; }
        private Figure _figure;

        private FigureDrawing _figureDraw;
        private FigureTransform _figureTransform;

        Point _moving;
        Side _resizing;  
               
        #region Constructors
        public FigureControl(Figure figure)
        {
            Initialize(figure);
        }
        public FigureControl() { }
        #endregion

        #region Initializations
        private void Initialize(Figure figure)
        {
            _figure = figure;
            _figureDraw = new FigureDrawing(this);
            _figureTransform = new FigureTransform(this);

            //ContextMenuStrip = new Components.ContextMenu();

            SetLocation();
        }
        #endregion

        #region MouseEvents
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _moving = e.Location;
                _resizing = GetSide(e.Location);                            
            }
            Focus();
            //ComponentEvents.OnActiveFigureChanged(this,e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            ChangeCursor(GetSide(e.Location));

            if (e.Button == MouseButtons.Left)
            {
                if (_resizing == Side.center)
                    _figureTransform.Move(_moving, e.Location);
                else
                    _resizing = _figureTransform.Resize(e.Location, _resizing);

            }
            //ComponentEvents.OnMouseMoved(this, e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            if(Focused == false)
                BorderStyle = BorderStyle.None;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }
        #endregion

        #region Helpfull methods
        public Side GetSide(Point point)
        {
            Side pos = Side.none;

            int x = point.X;
            int y = point.Y;

            int space = 10 + _figure.StrokeWidth;

            if (0 <= y && y <= space)
            {
                if (0 <= x && x <= space)
                    pos = Side.topLeft;
                else if (space <= x && x <= Width - space)
                    pos = Side.top;
                else if (Width - space <= x && x <= Width)
                    pos = Side.topRight;
            }
            else if (space <= y && y <= Height - space)
            {
                if (0 <= x && x <= space)
                    pos = Side.left;
                else if (space <= x && x <= Width - space)
                    pos = Side.center;
                else if (Width - space <= x && x <= Width)
                    pos = Side.right;
            }
            else if (Height - space <= y && y <= Height)
            {
                if (0 <= x && x <= space)
                    pos = Side.botLeft;
                else if (space <= x && x <= Width - space)
                    pos = Side.bot;
                else if (Width - space <= x && x <= Width)
                    pos = Side.botRight;
            }
            return pos;
        }
        private void ChangeCursor(Side pos)
        {
            if (pos == Side.top || pos == Side.bot)
                Cursor.Current = Cursors.SizeNS;
            else if (pos == Side.topRight || pos == Side.botLeft)
                Cursor.Current = Cursors.SizeNESW;
            else if (pos == Side.botRight || pos == Side.topLeft)
                Cursor.Current = Cursors.SizeNWSE;
            else if (pos == Side.right || pos == Side.left)
                Cursor.Current = Cursors.SizeWE;
            else if (pos == Side.startLine || pos == Side.endLine || pos == Side.center)
                Cursor.Current = Cursors.SizeAll;
            else
                Cursor.Current = Cursors.Arrow;
        }
        public void SetLocation()
        {
            if (Figure.Type != FType.Line)
                Location = Figure.Start;
            else
                Location = FPoint.TopLeft(_figure.Start, _figure.End);

            Refresh();
        }
        #endregion        

        #region Key Events
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            _moving = Location;
            int delta = 5;

            if (keyData == (Keys.Shift | Keys.Up))
                _resizing = _figureTransform.Resize(new Point(0, -delta), Side.top);
            else if (keyData == Keys.Up)
                _figureTransform.Move(_moving, new Point(Figure.Start.X, Figure.Start.Y - delta));

            else if (keyData == (Keys.Shift | Keys.Down))
                _resizing = _figureTransform.Resize(new Point(0, Figure.Size.Height + delta), Side.bot);
            else if (keyData == Keys.Down)
                _figureTransform.Move(_moving, new Point(Figure.Start.X, Figure.Start.Y + delta));

            else if (keyData == (Keys.Shift | Keys.Right))
                _resizing = _figureTransform.Resize(new Point(Figure.Size.Width + delta, 0), Side.right);
            else if (keyData == Keys.Right)
                _figureTransform.Move(_moving, new Point(Figure.Start.X + delta, Figure.Start.Y));

            else if (keyData == (Keys.Shift | Keys.Left))
                _resizing = _figureTransform.Resize(new Point(-delta, 0), Side.left);
            else if (keyData == Keys.Left)
                _figureTransform.Move(_moving, new Point(Figure.Start.X - delta, Figure.Start.Y));

            return true;
        }
        #endregion

        #region Focus Events
        protected override void OnGotFocus(EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }
        protected override void OnLostFocus(EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }
        #endregion

        #region Paint Event
        protected override void OnPaint(PaintEventArgs e)
        {
            _figureDraw.DrawFigure(e.Graphics);
        }
        #endregion

        #region Memento
        public void SetMemento(FigureMemento memento)
        {
            Initialize(memento.GetState());
        }
        public FigureMemento GetMemento()
        {
            return new FigureMemento(this);
        }
        #endregion

        #region Setters
        public void SetFigureColor(Color color)
        {
            _figure.Color = color;
            Invalidate();
        }
        public void SetFigureType(FType type)
        {
            _figure.Type = type;
            Invalidate();
        }
        public void SetStrokeWidth(int width)
        {
            _figure.StrokeWidth = width;
            Invalidate();
        }
        #endregion

        public System.Windows.Forms.Control NewFigure(Point start, Point end, IData data)
        {
            Initialize(new Figure(start, end, (data as Data)));
            return this;
        }
    }
}
