using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class TestTextBox : TextBox
    {
        Form1 _form1;

        public TestTextBox(string str, int x, int y, int Width, int Height)
        {

            Text = str;

            Location = new Point(x, y);

            Size = new Size(Width, Height);


        }


        /// <summary>
        /// テキストボックスに表示される文字を変える関数
        /// </summary>
        /// <param name="str"></param>
        public void TexTUpdateBox(string str)
        {
            Text = str;
        }


    }
}
