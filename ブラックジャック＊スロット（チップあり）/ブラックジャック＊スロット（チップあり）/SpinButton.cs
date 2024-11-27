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

        public SpinButton(Reel reel_x, Reel reel_y, Reel reel_z, int x, int y)
        {
            Reel_x = reel_x;
            Reel_y = reel_y;
            Reel_z = reel_z;
            Location = new Point(x, y);
            Size = new Size(70, 25); 
            Click += new EventHandler(SpinButton_Click);
            Text = "Spin";   

        }

        private void SpinButton_Click(object sender, EventArgs e)
        {
            try
            {
                Reel_x.Text = Reel_x.GetRandomSymbol().ToString();
                Reel_y.Text = Reel_y.GetRandomSymbol().ToString();
                Reel_z.Text = Reel_z.GetRandomSymbol().ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


    }
}
