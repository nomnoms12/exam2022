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
            if(this.name.Text != "" && this.surname.Text != "" && this.patronymic.Text != "" && this.year.Text != "")
            {
                MessageBox.Show($"Приветсствую тебя, О великий {this.surname.Text} {this.name.Text} {this.patronymic.Text} {this.year.Text}-ого года рождения!");
            }
            else
            {
                MessageBox.Show("Неопознанная форма жизнии");
            }
        }

        private void patronymic_Leave(object sender, EventArgs e)
        {
            this.patronymic.Enabled = false;
            this.checkBox1.Checked = false;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.patronymic.Enabled = true;
            }
            else
            {
                this.patronymic.Enabled = false;
            }
        }
    }
}
