using Paint.Command;
using Paint.UI.Tool.Strips;
using System.Drawing;
using System.Windows.Forms;

namespace Paint.UI.Tool
{
    public class ToolBar : ToolStrip
    {
        FileStrip fileStrip;
        CloudStrip cloudStrip;
        TabsStrip tabsStrip;

        private int _toolElementsCount = 0;

        public ToolBar(ICommand command)
        {
            BackColor = Color.White;           

            tabsStrip = new TabsStrip(command);
            fileStrip = new FileStrip(command);
            cloudStrip = new CloudStrip(command);

            Items.AddRange(tabsStrip.StripList);
            Items.Add(new ToolStripSeparator());

            Items.AddRange(fileStrip.StripList);
            Items.Add(new ToolStripSeparator());

            Items.AddRange(cloudStrip.StripList);
            Items.Add(new ToolStripSeparator());
        }

        public void AddPluginToolItems(ToolStripItem[] itemList)
        {
            Items.AddRange(itemList);
            _toolElementsCount = itemList.Length;
        }

        public void RemovePluginToolItems()
        {
            for (int i = 0; i < _toolElementsCount; i++)
            {
                Items.RemoveAt(Items.Count - 1);
            }
            _toolElementsCount = 0;
        }
    }
}
