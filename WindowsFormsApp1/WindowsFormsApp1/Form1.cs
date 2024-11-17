﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TestButton _testButton;
        
        TesrLabel _testlabel;

        TestTextBox _testtextbox;

        public Form1()
        {
            InitializeComponent();

            /**
            int x = 0;
            int y = 0;
            int flagx = 0;
            int flagy = 0;  

            while (flagx <= 10)
            {

                while (flagy <= 100)
                {
                    TestButton testbutton = new TestButton(x, y, 25, 100);
                    Controls.Add(testbutton);

                    x += 25;
                    flagy++;

                }

                y += 100;
                x = 0;
                flagy = 0;
                flagx++;

            }

            **/

            string[] str = new string[10] {"明","日","今","日","よ","り","も","強","く","な"};


                for (int i = 0; i < 10; i++)
                {
                    int a = (i + 1) % 10;
                    _testButton = new TestButton(this, (i % 3) * 100, (i / 3) * 100, 100, 100, str[i]);
                    Controls.Add(_testButton);
                }



            /*
            Label label = new Label();
            label.Location = new Point(30, 400);
            label.Name = "らべるです";
            Controls.Add(label);
            */

            //ラベルの作成
            _testlabel = new TesrLabel("らべるです", 30, 400, 100, 500);
            //ラベルの追加
            Controls.Add(_testlabel);

            //テキストボックスの作成
            _testtextbox = new TestTextBox("る", 150, 400, 1000, 500);
            //テキストボックスの追加
            Controls.Add(_testtextbox);




        }

        public void ButtonTextUpdate(string str)
        {
            _testButton.TexTUpdateButton(str);
        }

        public void LabelTextUpdate(string str)
        {
            _testlabel.TexTUpdate(str);
        }

        public void BoxTextUpdate(string str)
        {
            _testtextbox.TexTUpdateBox(str);
        }


    }
}
