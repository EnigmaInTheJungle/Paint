using Paint.Command;
using Paint.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.Tabs
{
    public class Tabs : TabControl
    {
        XCommand _command;
        private const string _defName = "Page";

        public Paint.UI.Tabs.Page.Page ActivePage => SelectedTab as Paint.UI.Tabs.Page.Page;
        //public FigureControl ActiveFigure;

        public Tabs(XCommand command)
        {
            Dock = DockStyle.Fill;
            _command = command;

            AddPage();
        }

        protected override void OnSelected(TabControlEventArgs e)
        {
            if (SelectedTab != null)
                _command.Data = (SelectedTab as Paint.UI.Tabs.Page.Page).CurrentData;
        }

        public void SetNewData(IData data)
        {
            ActivePage.DrawPanel.Data = data;
            _command.Data = data;

        }

        public void AddPage(string name = _defName)
        {
            Paint.UI.Tabs.Page.Page page = new Paint.UI.Tabs.Page.Page(name);
            TabPages.Add(page);

            _command.Data = page.CurrentData;
            SelectedTab = page;

            //if (TabPages.Count == 1)
            //    (Parent as Frame).IsAnyTabExist = true;
        }

        public void RemovePage(TabPage page)
        {
            TabPages.Remove(page);

            //if (TabPages.Count == 0)
            //    (Parent as Frame).IsAnyTabExist = false;
        }
        public void RenamePage(string name)
        {
            SelectedTab.Text = name;
            SelectedTab.Name = name;
        }
    }
}
