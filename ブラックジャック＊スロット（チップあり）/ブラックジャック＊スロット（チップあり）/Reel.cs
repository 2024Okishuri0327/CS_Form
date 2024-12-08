﻿using System;
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

        List<int> symbols = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        Random random = new Random();

        public Reel(int x, int y)
        {
            
            Location = new Point(x, y);
            int size = 50;
            Size = new Size(size,size);
            this.Font = new System.Drawing.Font(this.Font.FontFamily, size*4/5);
            Text = "7 ";
            TextAlign = ContentAlignment.MiddleCenter;

        }


        public int GetRandomSymbol()
        {
            int index = random.Next(symbols.Count);
            return symbols[index];
        }
    }

}

