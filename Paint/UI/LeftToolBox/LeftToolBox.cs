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

namespace Paint.UI.ToolBox
{
    public partial class LeftToolBox : Panel
    {
        public LeftToolBox(ICommand command)
        {
            Dock = DockStyle.Left;
            BackColor = Color.DarkBlue;
            Width = 100;
        }

        public void AddPluginElement(Button button)
        {
            Controls.Add(button);
        }
        public void RemovePluginElement(string pluginName)
        {
            Controls.RemoveByKey(pluginName);
        }
    }
}
