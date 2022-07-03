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

        private void button_Click(object sender, EventArgs e)
        {
            this.label.Text = (Convert.ToInt32(this.label.Text) + 1).ToString();

            if(Convert.ToInt32(this.label.Text) % 2 == 0)
            {
                this.label.ForeColor = Color.Black;
            }
            else
            {
                this.label.ForeColor = Color.Red;
            }
        }
    }
}
