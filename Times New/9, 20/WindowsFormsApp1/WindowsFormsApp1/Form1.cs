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
            try
            {
                for (int i = 0; i < 3; i++)
                { 
                    for (int j = i; j < 3; j++)
                    {

                        var texBox1 = this.Controls[$"textBox{i}_{j}"];
                        var texBox2 = this.Controls[$"textBox{j}_{i}"];

                        int x1 = Convert.ToInt32(texBox1.Text);
                        int x2 = Convert.ToInt32(texBox2.Text);

                        texBox1.Text = x2.ToString();
                        texBox2.Text = x1.ToString();

                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
            
        }
    }
}

