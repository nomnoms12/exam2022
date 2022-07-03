using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    // Разработать следующий программный модуль: пользователь вводит целые
    // положительные числа в ячейки матрицы, после нажатия кнопки «выполнить»
    // происходит ее транспонирование. В случае если пользователь ввел не число
    // либо не все ячейки заполнены, то после нажатия кнопки должна быть
    // выведена надпись «ошибка ввода». Размер матрицы 3х3
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String t2 = textBox2.Text;
            String t3 = textBox3.Text;
            String t8 = textBox8.Text;

            textBox2.Text = textBox4.Text;
            textBox3.Text = textBox7.Text;
            textBox8.Text = textBox6.Text;

            textBox4.Text = t2;
            textBox7.Text = t3;
            textBox6.Text = t8;
        }
    }
}
