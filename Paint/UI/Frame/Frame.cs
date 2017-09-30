using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.Frame
{
    public class Frame : Panel
    {
        public Frame()
        {
            Dock = DockStyle.Fill;
            Controls.Add(new Paint.UI.MenuBar.MenuBar(new XCommand()));
        }
    }
}
