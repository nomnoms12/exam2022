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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = CreateGraphics();
            g.DrawRectangle(Pens.Black, new Rectangle(10, 10, 50, 50));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Convert.ToInt32(this.textBox1.Text) * Convert.ToInt32(this.textBox2.Text)).ToString());
        }
    }
}
