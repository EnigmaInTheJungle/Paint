using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.ToolBar.Strips
{
    public class TabsStrip
    {
        public ToolStripItem[] StripList { get; }

        public TabsStrip(XCommand command)
        {
            StripList = new ToolStripItem[]
            {
                new ToolStripButton(null,Properties.Resources.NewTab,command.AddPage.Action,"New File"),
                new ToolStripButton(null, Properties.Resources.CloseTab, command.RemovePage.Action, "Close Tab"),
                new ToolStripButton(null, Properties.Resources.CloseAllTab, command.RemoveAllPages.Action, "Close All Tabs")
            };
        }
    }
}
