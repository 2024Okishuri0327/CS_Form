using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsApp1
{

    class TestButton : Button
    {

        public TestButton(int x, int y, int Width, int Height, string input) 
        {
            // ClickイベントにOnClick関数を登録する
            Click += OnClick;
            Text = input;

            Location = new Point(x,y);
            Size = new Size(Width,Height);
        }

        public void OnClick(object sender, EventArgs s) 
        {
            MessageBox.Show(Text);
        }
    }
}
