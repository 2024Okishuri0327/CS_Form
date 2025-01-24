using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ブラックジャック_スロット_チップあり_
{
    public class Dealer : Label
    {
        public int Dnumber { get; set; } // プロパティとして定義し、初期化

        List<int> Dsymbols = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
        Random random = new Random();
        private Timer displayTimer;
        private int total;
        public int count;
        private int work;

        public Dealer(int x, int y)
        {
            Dnumber = 0; // Dnumberを初期化

            Location = new Point(x, y);
            int size = 150;
            Size = new Size(size, size);
            this.Font = new System.Drawing.Font(this.Font.FontFamily, size * 1 / 5);
            Text = "ディーラー";

            // タイマーを初期化
            displayTimer = new Timer();
            displayTimer.Interval = 1000; // 1秒ごとに更新
            displayTimer.Tick += new EventHandler(DisplayTimer_Tick);
        }

        public int GetRandomSymbol()
        {
            int index = random.Next(Dsymbols.Count);
            Dnumber = Dnumber + Dsymbols[index]; // リストの整数値を引っ張る時に加算しておくと、合計値が求められる
            return Dnumber;
        }

        // ディーラーの合計を計算して表示するメソッドを追加
        public void DisplayDealerTotal()
        {
            Dnumber = 0;
            total = 0; // totalを初期化
            count = 0;
            work = 0;
            Text = "0"; // 初期値を表示
            displayTimer.Start(); // タイマーを開始
        }

        private void DisplayTimer_Tick(object sender, EventArgs e)
        {
            if (count < 3)
            {
                work = GetRandomSymbol(); // GetRandomSymbolから値を取得
                total += work; // 取得した値をtotalに加算
                Text = $"{work}"; // ランダムな数値を表示
                count++;
            }
            else if(count >= 3)
            {
                displayTimer.Stop(); // タイマーを停止
            }
        }
    }
}