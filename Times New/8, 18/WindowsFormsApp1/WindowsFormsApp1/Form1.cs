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

        private void button1_Click(object sender, EventArgs e)
        {
            collor++;
            switch (collor)
            {
                case 1:
                    this.button1.BackColor = System.Drawing.Color.Green;
                    break;
                case 2:
                    this.button1.BackColor = System.Drawing.Color.Blue;
                    break;
                default:
                    collor = 0;
                    this.button1.BackColor = System.Drawing.Color.Red;
                    break;
            };
        }

        private int collor = 0;
    }
}
