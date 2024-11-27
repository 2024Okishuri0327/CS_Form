using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ブラックジャック_スロット_チップあり_
{
    public class ReelReturn : Label
    {
        Reel _Reel;

        public ReelReturn( Reel Reel_x, Reel Reel_y, Reel Reel_z,int x, int y)
        {
            _Reel = Reel_x;
            _Reel = Reel_y;
            _Reel = Reel_z;
            Location = new Point(x, y + 50 * 3);

        }

    }
}
