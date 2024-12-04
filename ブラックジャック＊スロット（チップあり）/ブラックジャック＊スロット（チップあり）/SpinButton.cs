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
        private Reel Reel_x;
        private Reel Reel_y;
        private Reel Reel_z;
        private ReelReturn ReelReturn_x;

        public SpinButton(Reel reel_x,ReelReturn reelreturn, int x, int y)
        {
            Reel_x = reel_x;
            ReelReturn_x = reelreturn;
            Location = new Point(x, y);
            Size = new Size(50, 25); 
            Click += new EventHandler(SpinButton_Click);
            Text = "Spin";   

        }

        private void SpinButton_Click(object sender, EventArgs e)
        {

            try
            {
                //Reelの数字をGetRandamSymbolから引っ張ってくる
                int Reel_x_Num = Reel_x.GetRandomSymbol();
                Reel_x.Text = Reel_x_Num.ToString();

                //1*3と確定したら消す
                //int Num = (Reel_x.GetRandomSymbol() + Reel_y.GetRandomSymbol() + Reel_z.GetRandomSymbol());
                //ReelReturn_x.Text = Num.ToString();
                int Num = 0;
                Num =+ (Reel_x_Num);
                ReelReturn_x.Text = Num.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


    }
}
