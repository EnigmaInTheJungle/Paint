using Paint.Command;
using System.Windows.Forms;

namespace Paint.UI.Status
{
    public class StatusBar : StatusStrip
    {
        ToolStripLabel mPos;
        ToolStripLabel pageName;

        public StatusBar(ICommand command)
        {
            mPos = new ToolStripLabel();
            pageName = new ToolStripLabel();

            mPos.Text = $"X:  Y:  ";
            pageName.Text = $"Page:";


            Items.Add(mPos);
            Items.Add(pageName);
        }    
    }
}
