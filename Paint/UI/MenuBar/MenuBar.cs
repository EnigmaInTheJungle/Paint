using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.Menu
{
    class MenuBar : MenuStrip
    {

        ToolStripMenuItem pageStrip;
        ToolStripMenuItem fileStrip;
        ToolStripMenuItem figureStrip;
        ToolStripMenuItem textStrip;
        ToolStripMenuItem tabStrip;
        ToolStripMenuItem langStrip;
        ToolStripMenuItem pluginStrip;

        ResourceManager LocRM;

        public MenuBar()
        {
            LocRM = new ResourceManager("Paint.Localization.En", Assembly.GetExecutingAssembly());
        }

        private ToolStripMenuItem GetFileStrip()
        {
            fileStrip = new ToolStripMenuItem("File", null);

            List<ToolStripMenuItem> fileItems = new List<ToolStripMenuItem>
            {
                new ToolStripMenuItem("Save as..", null, ComponentEvents.OnFiguresSaved),
                new ToolStripMenuItem("Load", null, ComponentEvents.OnFiguresLoaded)
            };

            foreach (var item in fileItems)
            {
                fileStrip.DropDownItems.Add(item);
            }
            return fileStrip;
        }
        private ToolStripMenuItem GetFigureStrip()
        {
            figureStrip = new ToolStripMenuItem(LocRM.GetString("Figure"), null);

            List<ToolStripMenuItem> figureItems = new List<ToolStripMenuItem>
            {
                new ToolStripMenuItem(LocRM.GetString("Color"), null, ComponentEvents.OnFigureColorChanged),
                GetDropDownStrip(LocRM.GetString("Width"), new List<string> { "1", "3", "5", "10", "20" }, ComponentEvents.OnStrokeWidthChanged),
                GetDropDownStrip(LocRM.GetString("Type"),
                new List<string> { LocRM.GetString("Rectangle"), LocRM.GetString("Curve"), LocRM.GetString("RRectangle"),
                    LocRM.GetString("Ellipse"), LocRM.GetString("Line") }, ComponentEvents.OnFigureTypeChanged)
            };

            foreach (var item in figureItems)
            {
                figureStrip.DropDownItems.Add(item);
            }
            return figureStrip;
        }
        private ToolStripMenuItem GetTextStrip()
        {
            textStrip = new ToolStripMenuItem("Text", null);

            List<ToolStripMenuItem> textItems = new List<ToolStripMenuItem>
            {
                new ToolStripMenuItem("Text..", null, ComponentEvents.OnTextChanged),
                new ToolStripMenuItem("Color", null, ComponentEvents.OnTextColorChanged),
                new ToolStripMenuItem("Font..", null, ComponentEvents.OnTextFontChanged),
                GetDropDownStrip("Rotation", new List<string> { "0", "45", "90", "135", "180" }, ComponentEvents.OnTextAngleChanged),
                GetDropDownStrip("Alignment", new List<string> { "Top Left", "Top", "Top Right", "Left", "Center", "Right", "Bot Left", "Bot", "Bot Right" }, ComponentEvents.OnTextAlignChanged)
            };

            foreach (var item in textItems)
            {
                textStrip.DropDownItems.Add(item);
            }
            return textStrip;
        }
        private ToolStripMenuItem GetLangStrip()
        {
            langStrip = new ToolStripMenuItem("Language", null);

            List<ToolStripMenuItem> textItems = new List<ToolStripMenuItem>
            {
                new ToolStripMenuItem("English", null, new System.EventHandler(ChangeLanguage)),
                new ToolStripMenuItem("Russian", null, new System.EventHandler(ChangeLanguage)),
                new ToolStripMenuItem("Ukrainian", null, new System.EventHandler(ChangeLanguage)),
            };

            foreach (var item in textItems)
            {
                langStrip.DropDownItems.Add(item);
            }
            return langStrip;
        }
        private ToolStripMenuItem GetPluginStrip()
        {
            pluginStrip = new ToolStripMenuItem("Plugin", null);

            ToolStripMenuItem fpl = new ToolStripMenuItem("Figure with Text", null);
            ToolStripMenuItem spl = new ToolStripMenuItem("Figure without Text", null);
            ToolStripMenuItem tpl = new ToolStripMenuItem("Figure with Image", null);

            fpl.Click += delegate { ConnectPlugin(fpl, new FigureTextPlugin()); };
            spl.Click += delegate { ConnectPlugin(spl, new FigurePlugin()); };
            tpl.Click += delegate { ConnectPlugin(tpl, new FigureImagePlugin()); };

            List<ToolStripMenuItem> textItems = new List<ToolStripMenuItem> { fpl, spl, tpl };

            foreach (var item in textItems)
            {
                pluginStrip.DropDownItems.Add(item);
            }
            return pluginStrip;
        }

        private void ConnectPlugin(ToolStripMenuItem menu, IPlugin plugin)
        {
            if (menu.CheckState == CheckState.Unchecked)
            {
                Button btn = new Button();
                btn.Name = plugin.Name;
                btn.Text = plugin.Name;
                btn.Dock = DockStyle.Bottom;
                btn.Click += (s, e) =>
                {
                    (Parent as Frame).Controls.RemoveByKey(plugin.GetPropertyEditor().Name);
                    (Parent as Frame).Controls.Add(plugin.GetPropertyEditor());
                };

                (Parent as Frame).TextToolBox.Controls.Add(btn);
                menu.CheckState = CheckState.Checked;
            }
            else
            {
                (Parent as Frame).TextToolBox.Controls.RemoveByKey(plugin.Name);
                (Parent as Frame).Controls.RemoveByKey(plugin.GetPropertyEditor().Name);
                menu.CheckState = CheckState.Unchecked;
            }
        }


        private void ChangeLanguage(object sender, EventArgs e)
        {
            (Parent as Frame).Language = (sender as ToolStripMenuItem).Text;
        }
        private ToolStripMenuItem GetTabStrip()
        {
            tabStrip = new ToolStripMenuItem("Tab", null);

            List<ToolStripMenuItem> tabItems = new List<ToolStripMenuItem>
            {
                new ToolStripMenuItem("Add", null, ComponentEvents.OnPageAdded),
                new ToolStripMenuItem("Remove", null, ComponentEvents.OnPageRemoved),
                new ToolStripMenuItem("Rename", null, ComponentEvents.OnPageRenamed)
            };

            foreach (var item in tabItems)
            {
                tabStrip.DropDownItems.Add(item);
            }
            return tabStrip;
        }
        private ToolStripMenuItem GetPageStrip()
        {
            pageStrip = new ToolStripMenuItem("Pages", null);
            return pageStrip;
        }
        private ToolStripMenuItem GetDropDownStrip(string ownerText, List<string> items, System.EventHandler onClick)
        {
            ToolStripMenuItem owner = new ToolStripMenuItem(ownerText, null);
            foreach (string itemText in items)
            {
                owner.DropDownItems.Add(new ToolStripMenuItem(itemText, null, onClick));
            }
            return owner;
        }

        public void AddPageStrip(string name)
        {
            ToolStripMenuItem pageItem = new ToolStripMenuItem(name, null, ComponentEvents.OnPageSelectedChanged, name);
            pageStrip.DropDownItems.Add(pageItem);
        }
        public void RemovePageStrip(string name)
        {
            pageStrip.DropDownItems.RemoveByKey(name);
        }
        public void RenamePageStrip(string curTab, string name)
        {
            pageStrip.DropDownItems.Find(curTab, true)[0].Text = name;
            pageStrip.DropDownItems.Find(curTab, true)[0].Name = name;
        }

    }
}
