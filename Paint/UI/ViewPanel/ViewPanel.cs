
using PluginInterface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint.UI.View
{
    public class ViewPanel : PictureBox
    {
        public IPluginContext Context { get; set; }
        private Point _startPoint;

        public ViewPanel()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.White;

            Image = new Bitmap(Width, Height);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                _startPoint = e.Location;
                if (Context.ActiveFigure != null)
                {
                    (Context.ActiveFigure as UserControl).BorderStyle = BorderStyle.None;
                    Context.ActiveFigure = null;
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (Math.Abs(e.Location.X - _startPoint.X) > 10 && Math.Abs(e.Location.Y - _startPoint.Y) > 10)
                Controls.Add(Context.Plugin.FigureView(_startPoint, e.Location, Context.Data).GetFigureControl());
        }
    }
}
