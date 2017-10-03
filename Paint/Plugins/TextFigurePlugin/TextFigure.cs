using Paint.Command;
using Paint.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Plugins.TextFigurePlugin
{
    class TextFigure : IPlugin
    {
        public string Name => "Figure with text";

        Data _data;
        public IData Data => _data;

        Command.Command command;

        public TextFigure(XCommand command)
        {
            _data = new Data();
            this.command = new Command.Command(command);
        }

        public List<ToolStripMenuItem> GetMenuBarItems()
        {
            return new List<ToolStripMenuItem>() { new FigureMenuStrip(command) , new TextMenuStrip(command)};
        }

        public UserControl GetPropertyEditor()
        {
            throw new NotImplementedException();
        }

        public ToolStripItem[] GetToolBarItems()
        {
            FigureToolStrip paintStrip = new FigureToolStrip(command);
            TextToolStrip textStrip = new TextToolStrip(command);

            return paintStrip.StripList.Concat(textStrip.StripList).ToArray();
        }

        public IData GetNewData()
        {
            return new Data();
        }
    }
}
