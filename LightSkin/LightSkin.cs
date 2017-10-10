using SkinInterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightSkin
{
    public class LightSkin : ISkin
    {
        public string Name => "Light";

        public Color MainColor {get; }
        public Bitmap MainBackground { get; }

        public LightSkin()
        {
            MainColor = Color.White;
            MainBackground = Images.Back;
        }

    }
}
