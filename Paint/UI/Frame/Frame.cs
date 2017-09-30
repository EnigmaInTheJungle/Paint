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

            XCommand command = new XCommand();
            
            Controls.Add(new Paint.UI.Tabs.Tabs(command));

            Controls.Add(new Paint.UI.DrawFigureType.DrawFigureType(command));
            Controls.Add(new Paint.UI.ToolBar.ToolBar(command));
            Controls.Add(new Paint.UI.MenuBar.MenuBar(command));
            Controls.Add(new Paint.UI.StatusBar.StatusBar(command));
        }
    }
}
