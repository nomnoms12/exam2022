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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.label1.Text = "X:" + (Cursor.Position.X - this.Location.X).ToString() + "Y:" + (Cursor.Position.Y - this.Location.Y).ToString();
        }
    }
}
