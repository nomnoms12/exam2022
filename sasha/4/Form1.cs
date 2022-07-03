using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point loc = e.Location;
            Graphics formGraphics = this.CreateGraphics();
            string drawString = loc.ToString();
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
     
            StringFormat drawFormat = new StringFormat();
            formGraphics.DrawString(drawString, drawFont, drawBrush, loc, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}
