using Paint.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Plugins.Manager
{
    public interface IPluginState
    {
        IData Data { get; }
        Control ActiveFigure { get; set; }
    }
}
