using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms;

namespace ブラックジャック_スロット_チップあり_
{
    internal class Pan_Label : Label
    {
        /// <summary>
        ///　汎用ラベル
        /// </summary>
        /// <param name="str">表示させたい文字列</param>
        /// <param name="x">横の位置情報/param>
        /// <param name="y">縦の位置情報</param>
        /// <param name="Width">横の大きさ</param>
        /// <param name="Height">縦の大きさ</param>
        public Pan_Label(string str, int x, int y, int Width, int Height)
        {
            Text = str+"枚";

            Location = new Point(x, y);

            Size = new Size(Width, Height);


        }

    }
}
