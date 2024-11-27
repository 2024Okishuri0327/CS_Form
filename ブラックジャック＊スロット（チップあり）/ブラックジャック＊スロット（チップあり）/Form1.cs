using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ブラックジャック_スロット_チップあり_
{
    public partial class Form1 : Form
    {


        public Form1() //Formに表示させたいオブジェクトはここにコーディングする
        {
            InitializeComponent();

            //チップの枚数を表示するコード。チップは横５０
            //引数２が横の位置
            //引数３が縦の位置

            //Reelを表示するコード。Reelは横１５０縦５０差。SpinButtonは横１４０縦３００
            //
            //

            // SpinReel_Alpha
            int x = 150;
            int y = 150;

            Reel Reel1 = new Reel(x, y+50*0);
            Controls.Add(Reel1);

            Reel Reel2 = new Reel(x, y+50*1);
            Controls.Add(Reel2);

            Reel Reel3 = new Reel(x, y+50*2);
            Controls.Add(Reel3);

            ReelReturn Re_Alpha = new ReelReturn(Reel1, Reel2, Reel3, x, y);
            Controls.Add(Re_Alpha);

            SpinButton SpinButton = new SpinButton(Reel1,Reel2,Reel3, x-10,y+50*4);
            Controls.Add(SpinButton);





            

            





        }





    }
}









