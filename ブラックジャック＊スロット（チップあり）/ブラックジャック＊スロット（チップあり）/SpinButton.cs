using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ブラックジャック_スロット_チップあり_
{
    internal class SpinButton:Button
    {

        /// <summary>
        /// クラス名Reelの汎用変数名
        /// </summary>
        private  Reel _Reel;

        public SpinButton(int x, int y)
        {
            Text = "Spin";
            Location = new Point(x, y);
            Click += new EventHandler(SpinButton_Click);
            string Retrun = _Reel.Text;


        }

        private void SpinButton_Click(object sender, EventArgs e)
        {
            _Reel.Text = _Reel.GetRandamSymbol().ToString();

        }


    }
}
