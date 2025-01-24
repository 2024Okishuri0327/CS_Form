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
        Reel _ReelX;
        Reel _ReelY;
        Reel _ReelZ;

        private int totalSum;

        public int TotalSum
        {
            get { return totalSum; }
            set
            {
                totalSum = value;
                this.Text = totalSum.ToString();
            }
        }

        public ReelReturn(int x, int y)
        {
            totalSum = 0;
            this.Text = totalSum.ToString();
            Location = new Point(x, y);
        }

        public void AddToTotal(int value)
        {
            TotalSum += value;
        }


        //public ReelReturn(Reel Reel_x, Reel Reel_y, Reel Reel_z, int x, int y)
        //{
        //  _ReelX = Reel_x;
        //  _ReelY = Reel_y;
        //  _ReelZ = Reel_z;
        //  Location = new Point(x, y);
        //  Size = new Size(50, 50);
        //Text = SpinButton.totalSum;




    }
}
