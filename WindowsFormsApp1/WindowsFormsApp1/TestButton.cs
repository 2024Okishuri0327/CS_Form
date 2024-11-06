﻿using System;
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
        Form1 _form1;

        public TestButton(Form1 form1, int x, int y, int Width, int Height, string input) 
        {

            _form1 = form1;

            // ClickイベントにOnClick関数を登録する
            Click += OnClick;
            Text = input;

            Location = new Point(x,y);
            Size = new Size(Width,Height);
        }

        public void OnClick(object sender, EventArgs s) 
        {
            _form1.LabelTextUpdate(Text);
        }
    }
}
