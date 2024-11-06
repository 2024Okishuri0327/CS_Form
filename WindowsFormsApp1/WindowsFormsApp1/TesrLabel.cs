using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class TesrLabel: Label
    {

        public TesrLabel(string str,int x, int y, int Width, int Height)
        {
            Text = str;

            Location = new Point(x, y);

            Size = new Size(Width, Height);


        }

       


    }

}

