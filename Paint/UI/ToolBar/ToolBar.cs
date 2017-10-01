using Paint.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.ToolBar
{
    public class ToolBar : ToolStrip
    {
        FileStrip fileStrip;
        CloudStrip cloudStrip;
        
        

        public ToolBar(XCommand command)
        {
            BackColor = Color.White;

            fileStrip = new FileStrip(command);
            cloudStrip = new CloudStrip(command);

            Items.AddRange(fileStrip.FileStripList);
            Items.Add(new ToolStripSeparator());
            Items.AddRange(cloudStrip.CloudStripList);
            Items.Add(new ToolStripSeparator());
        }

        public void AddToolItems(ToolStripItem[] itemList)
        {
            Items.AddRange(itemList);
        }

        public void RemoveToolItems(ToolStripItem[] itemList)
        {
            for (int i = 0; i < itemList.Length; i++)
            {
                Items.RemoveAt(Items.Count - 1);
            }           
        }
    }
}
