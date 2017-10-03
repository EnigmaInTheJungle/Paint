using Paint.Data;
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
        public IData Data { get; set; }

        public ViewPanel()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.White;

            Image = new Bitmap(Width, Height);
        }
    }
}
