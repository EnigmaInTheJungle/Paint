using Paint.Command;
using Paint.UI.ToolBar.Strips;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.Bars
{
    public class ToolBar : ToolStrip
    {
        FileStrip fileStrip;
        CloudStrip cloudStrip;
        TabsStrip tabsStrip;
               
        public ToolBar(ICommand command)
        {
            BackColor = Color.White;           

            tabsStrip = new TabsStrip(command);
            fileStrip = new FileStrip(command);
            cloudStrip = new CloudStrip(command);

            Items.AddRange(tabsStrip.StripList);
            Items.Add(new ToolStripSeparator());

            Items.AddRange(fileStrip.StripList);
            Items.Add(new ToolStripSeparator());

            Items.AddRange(cloudStrip.StripList);
            Items.Add(new ToolStripSeparator());
        }
    }
}
