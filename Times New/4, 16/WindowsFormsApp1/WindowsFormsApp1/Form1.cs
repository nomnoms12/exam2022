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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "x = " + Cursor.Position.X.ToString() + " y = " + Cursor.Position.Y.ToString();
            label1.Location = new Point(Cursor.Position.X - Location.X - 25, Cursor.Position.Y - Location.Y - 25);
        }
    }
}
