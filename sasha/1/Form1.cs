using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point loc = e.Location;
            Size size = new Size(50, 50);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.White);
            formGraphics.FillRectangle(myBrush, new Rectangle(loc, size));
            myBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}
