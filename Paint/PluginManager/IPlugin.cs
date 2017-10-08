using Paint.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Plugins
{
    public interface IPlugin
    {
        string Name { get;  }

        Control ActiveFigure { get; }
        Control GetNewFigure(Point start, Point end, IData data);    
        IData GetNewData();
        
        UserControl GetPropertyEditor();
        List<ToolStripMenuItem> GetMenuBarItems();
        ToolStripItem[] GetToolBarItems();
    }
}
