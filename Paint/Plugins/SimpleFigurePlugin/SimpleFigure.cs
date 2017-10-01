using Paint.Command;
using Paint.Data;
using Paint.PluginManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Plugins.SimpleFigurePlugin
{
    class SimpleFigure : IPlugin
    {
        public string Name => "Simple Figure";

        Data _data;
        public IData Data => _data;

        Command.Command command;

        public SimpleFigure(XCommand command)
        {
            _data = new Data();
            this.command = new Command.Command(command);
        }

        public List<ToolStripMenuItem> GetMenuBarItems()
        {
            return new List<ToolStripMenuItem>() { new PaintMenuStrip(command) };
        }

        public UserControl GetPropertyEditor()
        {
            throw new NotImplementedException();
        }

        public ToolStripItem[] GetToolBarItems()
        {
            PaintToolStrip paintStrip = new PaintToolStrip(command);
            return paintStrip.FileStripList;
        }

        public IData GetNewData()
        {
            return new Data();
        }
    }
}
