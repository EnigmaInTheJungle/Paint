
using Paint.UI.View;
using PluginInterface;
using System.Windows.Forms;

namespace Paint.UI.Tab
{
    public class Page : TabPage
    {
        private static int _count = 0;

        ViewPanel _viewPanel;

        public IPluginContext PageContext{ get => _viewPanel.Context; set => _viewPanel.Context = value; }

    public Page(string pageText)
        {
            Dock = DockStyle.Fill;

            Text = pageText + ((pageText == "Page") ? _count++.ToString() : "");
            Name = Text;

            _viewPanel = new ViewPanel();
            Controls.Add(_viewPanel);
        }

    }
}
