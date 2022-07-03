using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    // Разработать следующий программный модуль: в окне присутствуют 4 поля
    // ввода, чекбокс и кнопка обработчик. В поля вводятся Фамилия, Имя,
    // Отчество и год рождения. После нажатия кнопки обработки, должно
    // выводиться новое окно с надписью «Приветствую тебя, о Великий Фамилия
    // Имя Отчество, i-ого года рождения!» с соответствующими данными. Поле
    // ввода отчества доступно только при наличии галочки в чекбоксе. При
    // незаполненных доступных для ввода полях должна выводиться надпись в
    // первом окне «Неопознанная форма жизни»
    public partial class Form1 : Form
    {
        bool is_textbox_enabled = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string last_name = textBox1.Text;
            string name = textBox2.Text;
            string second_name = textBox3.Text;
            string born = textBox4.Text;

            string t = string.Format("Приветствую тебя, о Великий {0} {1} {2}, {3}-ого года рождения!", last_name, name, second_name, born);

            if(last_name != "" && name != "" && born != "")
            {
                MessageBox.Show(t);
            }
            else
            {
                MessageBox.Show("Неопознанная форма жизни!!!!!!!!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            is_textbox_enabled = !is_textbox_enabled;
            textBox3.Enabled = is_textbox_enabled;
        }
        
    }
}
