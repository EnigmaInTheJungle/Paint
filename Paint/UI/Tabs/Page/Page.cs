using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Paint.Data;

namespace Paint.UI.Tabs.Page
{
    public class Page : TabPage
    {
        private static int _count = 0;

        public Paint.UI.DrawPanel.DrawPanel DrawPanel => _drawPanel;
        private Paint.UI.DrawPanel.DrawPanel _drawPanel;

        public IData CurrentData => _drawPanel.Data;

        public Page(string pageText)
        {
            Dock = DockStyle.Fill;

            Text = pageText + ((pageText == "Page") ? _count++.ToString() : "");
            Name = Text;

            _drawPanel = new Paint.UI.DrawPanel.DrawPanel();
            Controls.Add(_drawPanel);
        }

    }
}
