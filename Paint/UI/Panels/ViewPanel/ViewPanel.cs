using Paint.Command;
using Paint.Data;
using Paint.Plugins;
using Paint.Plugins.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.Panels
{
    public class ViewPanel : PictureBox
    {
        public IPluginState State { get; set; }
        public IPlugin Plugin { get; set; }
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
                if (State.ActiveFigure != null)
                {
                    (State.ActiveFigure as UserControl).BorderStyle = BorderStyle.None;
                    State.ActiveFigure = null;
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
                Controls.Add(Plugin.GetNewFigure(_startPoint, e.Location, State.Data));
        }
    }
}
