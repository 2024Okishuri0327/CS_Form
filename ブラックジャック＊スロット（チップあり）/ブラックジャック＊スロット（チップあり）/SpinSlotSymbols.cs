using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ブラックジャック_スロット_チップあり_
{
    internal class SpinSlotSymbols
    {

        List<int> symbols = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        Random random = new Random();

        public int SpinSlot()
        {
            int index = random.Next(symbols.Count);
            return symbols[index];
        }
    }
}
