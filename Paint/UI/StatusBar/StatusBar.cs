using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.StatusBar
{
    public class StatusBar : StatusStrip
    {
        DataStrip dataStrip;

        public StatusBar(XCommand command)
        {
            dataStrip = new DataStrip(command);

            Items.Add(dataStrip.GetMousePos());
            Items.Add(dataStrip.GetPageName());
        }
    }
}
