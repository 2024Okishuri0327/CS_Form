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
    public class Reel : Label
    {

        List<string> symbols = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        Random random = new Random();
        public int Reel_Num;

        public Reel(int x, int y)
        {
            
            Location = new Point(x, y);
            int size = 50;
            Size = new Size(size,size);
            this.Font = new System.Drawing.Font(this.Font.FontFamily, size*3/5);
            Text = "7 ";
            TextAlign = ContentAlignment.MiddleCenter;

        }


        public string GetRandomSymbol()
        {
            int index = random.Next(symbols.Count);
            Reel_Num = ConvertValue(symbols[index]); //リストの整数値を引っ張る時に加算しておくと、合計値が求められる
            return (symbols[index]);
        }


        private int ConvertValue(string value)
        {
            if (value == "J" || value == "Q" || value == "K")
            {
                return 10;
            }
            return int.TryParse(value, out int result) ? result : 0;
        }


    }



}

