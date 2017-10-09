using Paint.Command;
using PluginInterface;
using System.Windows.Forms;

namespace Paint.UI.Tab
{
    public class Tabs : TabControl
    {
        XCommand _command;

        public Page ActivePage => SelectedTab as Page;

        public IPluginContext PageContext { get => ActivePage.PageContext; set => ActivePage.PageContext = value; }

        private const string _defaultName = "Page";

        public Tabs(XCommand command)
        {
            Dock = DockStyle.Fill;
            _command = command;
        }

        protected override void OnSelected(TabControlEventArgs e)
        {
            _command.SelectPage.Action(this, e);
        }

        public void AddPage(string name = _defaultName)
        {
            Page page = new Page(name);
            TabPages.Add(page);
            SelectTab(page);
        }

        public void RemovePage()
        {
            TabPages.Remove(ActivePage);
        }

        public void RenamePage(string name)
        {
            ActivePage.Text = name;
            ActivePage.Name = name;
        }
    }
}
