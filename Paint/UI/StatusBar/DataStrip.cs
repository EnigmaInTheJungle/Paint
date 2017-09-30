using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.StatusBar
{
    public class DataStrip : StatusStrip
    {
        ToolStripLabel mPos;
        ToolStripLabel pageName;

        public DataStrip(XCommand command)
        {
            mPos = new ToolStripLabel();
            pageName = new ToolStripLabel();
        }

        public string GetMousePos()
        {
            string coord = mPos.Text = $"x: y: ";

            return coord;
        }

        public string GetPageName()
        {
            string coord = pageName.Text = $"PageName";

            return coord;
        }
    }
}
