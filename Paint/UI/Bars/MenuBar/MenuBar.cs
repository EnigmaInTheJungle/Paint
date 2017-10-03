using Paint.Command;
using Paint.UI.MenuBar.Strips;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Paint.UI.Bars
{
    public class MenuBar : MenuStrip
    {
        public static ResourceManager Localization { get; private set; }

        public MenuBar(ICommand command)
        {
            BackColor = Color.White;

            Items.Add(new FileStrip(command));
            Items.Add(new PaintStrip());
            Items.Add(new WindowStrip(command));
            Items.Add(new ViewStrip(command));
            Items.Add(new SettingsStrip(command));
            Items.Add(new HelpStrip(command));

            //Localization = new ResourceManager("Paint.Localization.En", Assembly.GetExecutingAssembly());
        }      
    }
}
