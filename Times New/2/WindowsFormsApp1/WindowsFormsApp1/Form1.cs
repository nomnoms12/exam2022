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

        private void Form1_Click(object sender, EventArgs e)
        {
            var g = CreateGraphics();
            for(int i = 10; i <= 640; i+=10)
                g.DrawLine(Pens.Green, new Point(i, 0), new Point(i, 480));

            for (int i = 10; i <= 480; i += 10)
                g.DrawLine(Pens.Green, new Point(0, i), new Point(640, i));
        }
    }
}
