using Paint.Data;
using Paint.Plugins.Manager;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Paint.Plugins
{
    public interface IPlugin
    {
        string Name { get;  }

        IPluginState GetNewState { get; }

        Control GetNewFigure(Point start, Point end, IData data);    
        
        UserControl GetPropertyEditor();
        List<ToolStripMenuItem> GetMenuBarItems();
        ToolStripItem[] GetToolBarItems();
    }
}
