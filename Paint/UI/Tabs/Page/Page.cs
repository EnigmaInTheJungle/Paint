using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Paint.UI.Tabs.Page
{
    public class Page : TabPage
    {
        private static int _count = 0;

        //public DrawPanel DrawPanel => _drawPanel;
        //private DrawPanel _drawPanel;

        //public XData CurrentData => _drawPanel.Data;

        public Page(string pageText)
        {
            Dock = DockStyle.Fill;
            BackColor = Color.White;

            Text = pageText + ((pageText == "Page") ? _count++.ToString() : "");
            Name = Text;

            //_drawPanel = new DrawPanel();
            //Controls.Add(_drawPanel);
        }
    }
}
