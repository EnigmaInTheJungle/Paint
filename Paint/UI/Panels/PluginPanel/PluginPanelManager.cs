using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paint.UI.Panels;
using System.Windows.Forms;

namespace Paint.UI.Managers
{
    public static class PluginPanelManager
    {
        private static PluginPanel _pluginPanel;

        public static void SetPluginPanel(PluginPanel pluginPanel)
        {
            _pluginPanel = pluginPanel;
        }

        public static void AddPluginElement(Button button)
        {
            _pluginPanel.Controls.Add(button);
        }
        public static void RemovePluginElement(string pluginName)
        {
            _pluginPanel.Controls.RemoveByKey(pluginName);
        }
    }
}
