using Paint.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Plugins
{
    public interface IPlugin
    {
        string Name { get;  }
        IFigureView Figure { get; }
        IData GetNewData();
        

        UserControl GetPropertyEditor();
        List<ToolStripMenuItem> GetMenuBarItems();
        ToolStripItem[] GetToolBarItems();
    }
}
