using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Paint.Data;
using Paint.UI.Panels;
using Paint.UI.Managers;

namespace Paint.UI.Tabs.Page
{
    public class Page : TabPage
    {
        private static int _count = 0;

        public ViewPanel ViewPanel => _viewPanel;
        private ViewPanel _viewPanel;

        public IData ActiveData => _viewPanel.Data;

        public Page(string pageText)
        {
            Dock = DockStyle.Fill;

            Text = pageText + ((pageText == "Page") ? _count++.ToString() : "");
            Name = Text;

            _viewPanel = new ViewPanel();
            Controls.Add(_viewPanel);
        }

    }
}
