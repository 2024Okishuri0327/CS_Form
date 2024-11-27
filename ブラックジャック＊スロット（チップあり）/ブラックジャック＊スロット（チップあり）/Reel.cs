using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ブラックジャック_スロット_チップあり_
{
    internal class Reel:Label
    {
        SpinButton _SpinButton;

        List<int> symbols = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        Random random = new Random();

        public Reel(int x, int y)
        { 
            Location = new Point(x, y);
            Size = new Size(50, 50);
            Font = new Font(Font.FontFamily, 24);

        }

        public int GetRandamSymbol()
        {
            int index = random.Next(symbols.Count);
            return symbols[index];
        }
    }
}
