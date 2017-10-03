using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint.Command;

namespace Paint.UI.Panels
{
    public partial class PluginPanel : Panel
    {
        public PluginPanel(XCommand command)
        {
            Dock = DockStyle.Left;
            BackColor = Color.DarkBlue;
            Width = 100;
        }
    }
}
