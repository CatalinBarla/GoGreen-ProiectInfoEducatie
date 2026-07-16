using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoGreen
{
    internal class Culori
    {
        public static Color DefaultColor = Color.FromArgb(200, 240, 200);

        public static Color Backgroundcolor = DefaultColor;
        public static Color TextColor = Color.Black;

        public static event EventHandler CuloriSchimbate;
        public static void NotificaSchimbare()
        {
            CuloriSchimbate?.Invoke(null, EventArgs.Empty);
        }
    }
}
