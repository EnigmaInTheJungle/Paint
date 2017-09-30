using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.Menu
{
    class FileStrip : ToolStripMenuItem
    {
        public FileStrip()
        {
            Name = "File";
                List<ToolStripMenuItem> fileItems = new List<ToolStripMenuItem>
            {
                new ToolStripMenuItem("Save as..", null, ComponentEvents.OnFiguresSaved),
                new ToolStripMenuItem("Load", null, ComponentEvents.OnFiguresLoaded)
            };

                foreach (var item in fileItems)
                {
                    fileStrip.DropDownItems.Add(item);
                }
                return fileStrip;
            }
        }

    }
}
