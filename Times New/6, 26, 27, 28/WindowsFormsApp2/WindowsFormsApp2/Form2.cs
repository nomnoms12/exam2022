using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2(int x0, int y0, int x1, int y1)
        {
            InitializeComponent();
            draw( x0, y0, x1, y1);
        }

        private void draw(int x0, int y0, int x1, int y1)
        {
            Bitmap image = new Bitmap(canvas.Width, canvas.Height);
            Graphics g = Graphics.FromImage(image);


            g.DrawRectangle(Pens.Orange, x0, y0, x1 - x0, y1 - y0);

            canvas.Image = image;
        }

    }
}
