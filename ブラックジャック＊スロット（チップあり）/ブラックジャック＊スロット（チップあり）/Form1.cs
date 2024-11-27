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

            //Reelを表示するコード。Reelは横１５０
            //
            //

            Reel Reel = new Reel(150, 150);
            Controls.Add(Reel);

            SpinButton SpinButton = new SpinButton(200,200);
            Controls.Add(SpinButton);


            

            





        }





    }
}









