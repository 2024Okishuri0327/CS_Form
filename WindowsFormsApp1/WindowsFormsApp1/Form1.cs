using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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


            for (int c = 0; c <= 10;  c++)
            {

            }

        }
    }
}
