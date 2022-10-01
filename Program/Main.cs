using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Main : Form
    {
        int number1, number2, number3;
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0)
            {
                MessageBox.Show("Заполните все текстовые поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                number1 = Convert.ToInt32(textBox1.Text);
                number2 = Convert.ToInt32(textBox2.Text);
                number3 = Convert.ToInt32(textBox3.Text);

                if ((number1 == number2) && (number2 == number3) && (number1 == number3))
                    MessageBox.Show("Треугольник равносторонний");
                else
                {
                    if ((number1 + number2 > number3) && (number1 + number3 > number2) && (number2 + number3 > number1))
                    {
                        if ((number1 == number2 && number1 != number3) || (number1 == number3 && number1 != number2) || (number2 == number3 && number2 != number1))
                            MessageBox.Show("Треугольник равнобедренный");
                        else
                            MessageBox.Show("Треугольник разносторонний");
                    }
                    else MessageBox.Show("Не возможно построить треугольник!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
            if (textBox1.Text.Length == 0)
                if (e.KeyChar == '0') e.Handled = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Определить вид треугольника");
            t.SetToolTip(button2, "Очистить все поля");
            t.SetToolTip(button3, "Заполнить поля случайными числами");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd  = new Random();
            textBox1.Text = Convert.ToString(rnd.Next(0, 1000));
            textBox2.Text = Convert.ToString(rnd.Next(0, 1000));
            textBox3.Text = Convert.ToString(rnd.Next(0, 1000));
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
            if (textBox1.Text.Length == 0)
                if (e.KeyChar == '0') e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
            if (textBox1.Text.Length == 0)
                if (e.KeyChar == '0') e.Handled = true;
        }
    }
}
