using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ブラックジャック_スロット_チップあり_
{
    public class SpinButton : Button
    {
        private Reel Reel_x;
        private ReelReturn ReelReturn_x;
        public event EventHandler PressCountChanged;
        private List<SpinButton> spinButtons;
        private Timer resetTimer;
        public int totalSum = 0; // 合計を保持する変数

        public SpinButton(Reel reel_x, ReelReturn reelreturn, int x, int y, List<SpinButton> buttons)
        {
            Reel_x = reel_x;
            ReelReturn_x = reelreturn;
            Location = new Point(x, y);
            Size = new Size(50, 25);
            Text = "Spin";
            Click += new EventHandler(SpinButton_Click);

            spinButtons = buttons; // Form1から渡されたリストを使用

            // タイマーを初期化
            resetTimer = new Timer
            {
                Interval = 3000 // 3秒後にリセット
            };
            resetTimer.Tick += new EventHandler(ResetTimer_Tick);
        }

        private void SpinButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.Button_Press_Cnt++;

                if (Form1.Button_Press_Cnt < 3)
                {
                    // Reelの数字をGetRandomSymbolから引っ張ってくる
                    string Reel_x_Num = Reel_x.GetRandomSymbol();
                    Reel_x.Text = Reel_x_Num;

                    // ReelReturn_xに値を設定
                    ReelReturn_x.Text = Reel_x_Num;

                    // 合計を計算して表示
                    totalSum += ConvertValue(Reel_x_Num);
                }
                else if (Form1.Button_Press_Cnt == 3)
                {
                    Text = "Reset";
                    foreach (var button in spinButtons)
                    {
                        button.Text = "Reset";
                    }
                    resetTimer.Start(); // タイマーを開始
                }
                else if (Text == "Reset")
                {
                    Form1.Button_Press_Cnt = 0;
                    Text = "Spin";
                    foreach (var button in spinButtons)
                    {
                        button.Text = "Spin";
                    }
                }

                PressCountChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ResetTimer_Tick(object sender, EventArgs e)
        {
            resetTimer.Stop(); // タイマーを停止
            Form1.Button_Press_Cnt = 0;
            foreach (var button in spinButtons) // すべてボタンのテキストを「Spin」に戻す
            {
                button.Text = "Spin";
            }
            
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