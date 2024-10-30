using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsApp1
{

    class TestButton : Button
    {
        public TestButton() 
        {
            // ClickイベントにOnClick関数を登録する
            Click += OnClick;
        }

        public void OnClick(object sender, EventArgs s) 
        {
            MessageBox.Show("なんでもいいのでテキストを打ち込んでください");
        }
    }
}
