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
        private Dealer dEaler; // Dealerのインスタンスを保持するフィールドを追加
        private ReelReturn Re_Alpha;

        private Reel Reel_x;
        private ReelReturn ReelReturn_x;
        public event EventHandler PressCountChanged;
        private List<SpinButton> spinButtons;
        private Timer resetTimer;
        public int totalSum = 0; // 合計を保持する変数

        public SpinButton(Reel reel_x, ReelReturn reelreturn, Dealer dealer, ReelReturn re_alpha, int x, int y, List<SpinButton> buttons)
        {
            Reel_x = reel_x;
            ReelReturn_x = reelreturn;
            dEaler = dealer ?? throw new ArgumentNullException(nameof(dealer)); // dealerを初期化
            Re_Alpha = re_alpha ?? throw new ArgumentNullException(nameof(re_alpha)); // Re_Alphaを初期化
            Location = new Point(x, y);
            Size = new Size(50, 25);
            Text = "Spin";
            Click += new EventHandler(SpinButton_Click);

            spinButtons = buttons; // Form1から渡されたリストを使用

            // タイマーを初期化
            resetTimer = new Timer
            {
                Interval = 4000 // 4秒後にリセット
            };
            resetTimer.Tick += new EventHandler(ResetTimer_Tick);
        }

        private void SpinButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Form1.Button_Press_Cnt == 0)
                {
                    ReelReturn_x.TotalSum = 0;
                }
                Form1.Button_Press_Cnt++;

                if (Form1.Button_Press_Cnt < 3)
                {
                    // Reelの数字をGetRandomSymbolから引っ張ってくる
                    string Reel_x_Num = Reel_x.GetRandomSymbol();
                    Reel_x.Text = Reel_x_Num;

                    // 合計を計算して表示
                    ReelReturn_x.AddToTotal(Reel_x.Reel_Num);
                }
                else if (Form1.Button_Press_Cnt == 3)
                {
                    // Reelの数字をGetRandomSymbolから引っ張ってくる
                    string Reel_x_Num = Reel_x.GetRandomSymbol();
                    Reel_x.Text = Reel_x_Num;

                    // 合計を計算して表示
                    ReelReturn_x.AddToTotal(Reel_x.Reel_Num);

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
            try
            {
                resetTimer.Stop(); // タイマーを停止
                Form1.Button_Press_Cnt = 0;
                foreach (var button in spinButtons) // すべてボタンのテキストを「Spin」に戻す
                {
                    button.Text = "Spin";
                }

                // ディーラーの合計値が表示されたときにInitializeCompareを呼び出す
                if (dEaler.count == 0)
                {
                    InitializeCompare();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private int ConvertValue(string value)
        {
            try
            {
                if (value == "J" || value == "Q" || value == "K")
                {
                    return 10;
                }
                return int.TryParse(value, out int result) ? result : 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return 0;
            }
        }

        private void InitializeCompare()
        {
            try
            {
                // ディーラーの合計値を引っ張る
                int Dealer_Num = dEaler.Dnumber;
                // プレイヤーの合計値を引っ張る
                int Player_Num_A = Re_Alpha.TotalSum;

                // どちらの合計値も21より大きいまたはプレイヤーの合計値とディーラーの合計値が等しいならば引き分け
                if ((Dealer_Num > 21 && Player_Num_A > 21) || Dealer_Num == Player_Num_A)
                {
                    // 引き分けの演出
                    MessageBox.Show("引き分けです！", "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // ディーラーの合計値が21以下かつプレイヤーの合計値より大きいならばプレイヤーの勝利
                else if (Player_Num_A <= 21)
                {
                    if ((Player_Num_A > Dealer_Num || Dealer_Num > 21))
                    {
                        // プレイヤーの勝利の演出
                        MessageBox.Show("プレイヤーの勝利です！", "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // ディーラーの合計値が21以下かつプレイヤーの合計値より大きいならばディーラーの勝利
                else if (Dealer_Num <= 21 && (Dealer_Num > Player_Num_A || Player_Num_A > 21))
                {
                    if ((Dealer_Num > Player_Num_A || Player_Num_A > 21))
                    {
                        // ディーラーの勝利の演出
                        MessageBox.Show("ディーラーの勝利です！", "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}