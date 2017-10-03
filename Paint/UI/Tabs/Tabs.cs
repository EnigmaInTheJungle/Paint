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

        public Page.Page ActivePage => SelectedTab as Page.Page;

        public Tabs(XCommand command)
        {
            Dock = DockStyle.Fill;
            _command = command;
        }

        protected override void OnSelected(TabControlEventArgs e)
        {
            PullActiveData();
        }

        public void PullActiveData()
        {
            if (ActivePage != null)
                _command.Data = ActivePage.ActiveData;
        }
    }
}
