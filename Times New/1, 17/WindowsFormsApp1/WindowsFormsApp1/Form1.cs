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
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap image = new Bitmap(canvas.Width, canvas.Height);
            Graphics g = Graphics.FromImage(image);


            g.DrawRectangle(Pens.Orange, e.Location.X, e.Location.Y, 50, 50);

            canvas.Image = image;
        }
    }
}
