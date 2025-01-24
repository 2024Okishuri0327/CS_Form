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
        public Label countLabel;
        public static int Button_Press_Cnt;
        public List<SpinButton> spinButtons = new List<SpinButton>();
        private Dealer dealer = new Dealer(750, 150); // 必要なパラメータを渡して初期化 // Dealerのインスタンスを保持するフィールドを追加
        private ReelReturn Re_Alpha;

        public Form1()
        {
            InitializeComponent();
            Button_Press_Cnt = 0; // カウンタを初期化

            InitializeReelsAndButtons();
            InitializeDealer();
            InitializeCountLabel();
            //InitializeCompare();


        }



        // リールとボタンの初期化を分離してメソッド化
        private void InitializeReelsAndButtons()
        {
            int x = 150;
            int y = 150;

            Reel Reel1 = new Reel(x, y);
            Controls.Add(Reel1);

            Reel Reel2 = new Reel(x + 150, y);
            Controls.Add(Reel2);

            Reel Reel3 = new Reel(x + 300, y);
            Controls.Add(Reel3);

            //ReelReturn Re_Alpha = new ReelReturn(Reel1, Reel2, Reel3, x + 450, y + 75);
            Re_Alpha = new ReelReturn( x + 450, y + 75);
            Controls.Add(Re_Alpha);

            AddSpinButton(Reel1, Re_Alpha, x, y + 75);
            AddSpinButton(Reel2, Re_Alpha, x + 150, y + 75);
            AddSpinButton(Reel3, Re_Alpha, x + 300, y + 75);
        }

        // SpinButtonの追加をメソッド化
        private void AddSpinButton(Reel reel, ReelReturn reelReturn, int x, int y)
        {
            SpinButton spinButton = new SpinButton(reel, reelReturn, dealer, Re_Alpha, x, y, spinButtons);
            Controls.Add(spinButton);
            spinButton.PressCountChanged += SpinButton_PressCountChanged;
            spinButtons.Add(spinButton);
        }

        // Dealerの初期化を分離してメソッド化
        private void InitializeDealer()
        {
            int x = 150;
            int y = 150;
            dealer = new Dealer(x + 600, y);
            Controls.Add(dealer);
        }

        // カウントラベルの初期化を分離してメソッド化
        private void InitializeCountLabel()
        {
            countLabel = new Label
            {
                Location = new Point(750, 225),
                Size = new Size(100, 25),
                Text = "Count: 0"
            };
            Controls.Add(countLabel);
        }

        private void SpinButton_PressCountChanged(object sender, EventArgs e)
        {
            countLabel.Text = $"Count: {Button_Press_Cnt}";

            if (Button_Press_Cnt == 3)
            {
                foreach (var button in spinButtons)
                {
                    button.Text = "Reset";
                }
                dealer.DisplayDealerTotal(); // ディーラーの合計を表示
            }
        }


    }

}
