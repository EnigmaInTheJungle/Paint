using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PluginInterface
{
    public interface IPlugin
    {
        string Name { get;  }

        IPluginContext GetNewContext { get; }
        IPluginContext SetContext { set; }

        IFigureView FigureView(Point start, Point end, IData data);
        
        UserControl GetPropertyEditor();
        List<ToolStripMenuItem> GetMenuBarItems();
        ToolStripItem[] GetToolBarItems();
    }
}
