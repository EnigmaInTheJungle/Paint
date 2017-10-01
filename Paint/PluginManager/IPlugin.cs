using Paint.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.PluginManager
{
    public interface IPlugin
    {
        string Name { get;  }
        IData Data { get; }

        IData GetNewData();

        UserControl GetPropertyEditor();
        List<ToolStripMenuItem> GetMenuBarItems();
        ToolStripItem[] GetToolBarItems();
    }
}
