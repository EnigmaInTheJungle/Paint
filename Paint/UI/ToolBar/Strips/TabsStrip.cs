using Paint.Command;
using Paint.Properties;
using Paint.Resources.Icons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.Tool.Strips
{
    public class TabsStrip
    {
        public ToolStripItem[] StripList { get; }

        public TabsStrip(ICommand command)
        {
            StripList = new ToolStripItem[]
            {
                new ToolStripButton(null,Icons.NewTab,command.AddPage.Action,"New File"),
                new ToolStripButton(null, Icons.CloseTab, command.RemovePage.Action, "Close Tab"),
                new ToolStripButton(null, Icons.CloseAllTab, command.RemoveAllPages.Action, "Close All Tabs")
            };
        }
    }
}
