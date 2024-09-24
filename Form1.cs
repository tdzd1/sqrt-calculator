using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)//При нажатии на кнопку 5(Посчитать)
        {
            int kolvo_znakov;
            double chislo = Convert.ToDouble(textBox1.Text);//Строку из поля ввода конвертируем в тип double
            bool isSuccsess=int.TryParse(textBox2.Text, out kolvo_znakov);//Строку из поля ввода кол-ва знаков полсе запятой конвертируем в тип int

            if (isSuccsess==true)
            {
                if (chislo >= 0)//Если число больше либо равно 0
                {
                    double result = Math.Round(Math.Sqrt(chislo * 1.0), kolvo_znakov);//То в результат присваиваем квадратный корень числа с заданным кол-вом знаков полсе запятой
                    textBox3.Text = "+-" + result.ToString();//В поле поле для вывода выводится +- и значение корня

                }
                else//если число меньше 0
                {
                    double result = Math.Round(Math.Sqrt(Math.Abs(chislo * 1.0)), kolvo_znakov);//То в результат присваиваем квадратный корень модуля числа с заданным кол-вом знаков полсе запятой
                    textBox3.Text = "+-" + result.ToString() + 'i';//В поле поле для вывода выводится +- и значение корня
                }
            }
            else
            {
                if (chislo >= 0)//Если число больше либо равно 0
                {
                    double result = Math.Sqrt(chislo * 1.0);//То в результат присваиваем квадратный корень числа с заданным кол-вом знаков полсе запятой
                    textBox3.Text = "+-" + result.ToString();//В поле поле для вывода выводится +- и значение корня

                }
                else//если число меньше 0
                {
                    double result = Math.Sqrt(Math.Abs(chislo * 1.0));//То в результат присваиваем квадратный корень модуля числа с заданным кол-вом знаков полсе запятой
                    textBox3.Text = "+-" + result.ToString() + 'i';//В поле поле для вывода выводится +- и значение корня
                }
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        
        }
        private void button10_Click(object sender, EventArgs e)//При нажатии на кнопку 10(5)
        {
            textBox1.Text = textBox1.Text + 5;//В поле ввода вводится цифра 5
        }

        private void button11_Click(object sender, EventArgs e)//При нажатии на кнопку 11(6)
        {
            textBox1.Text = textBox1.Text + 6;//В поле ввода вводится цифра 6
        }

        private void button13_Click(object sender, EventArgs e)//При нажатии на кнопку 13(2)
        {
            textBox1.Text = textBox1.Text + 2;//В поле ввода вводится цифра 2
        }

        private void button6_Click(object sender, EventArgs e)//При нажатии на кнопку 6(7)
        {
            textBox1.Text = textBox1.Text + 7;//В поле ввода вводится цифра 7
        }

        private void button7_Click(object sender, EventArgs e)//При нажатии на кнопку 7(8)
        {
            textBox1.Text = textBox1.Text + 8;//В поле ввода вводится цифра 8
        }

        private void button8_Click(object sender, EventArgs e)//При нажатии на кнопку 8(9)
        {
            textBox1.Text = textBox1.Text + 9;//В поле ввода вводится цифра 9
        }

        private void button9_Click(object sender, EventArgs e)//При нажатии на кнопку 9(4)
        {
            textBox1.Text = textBox1.Text + 4;//В поле ввода вводится цифра 4
        }

        private void button12_Click(object sender, EventArgs e)//При нажатии на кнопку 12(1)
        {
            textBox1.Text = textBox1.Text + 1;//В поле ввода вводится цифра 1
        }

        private void button14_Click(object sender, EventArgs e)//При нажатии на кнопку 14(3)
        {
            textBox1.Text = textBox1.Text + 3;//В поле ввода вводится цифра 3
        }

        private void button15_Click(object sender, EventArgs e)//При нажатии на кнопку 15(0)
        {
            textBox1.Text = textBox1.Text + 0;//В поле ввода вводится цифра 0
        }

        private void button16_Click(object sender, EventArgs e)//При нажатии на кнопку 16(.)
        {
            textBox1.Text = textBox1.Text + '.';//В поле ввода вводится .
        }

        private void button17_Click(object sender, EventArgs e)//При нажатии на кнопку 17(-)
        {
            textBox1.Text = textBox1.Text + '-'; //В поле ввода вводится -
        }

        private void button18_Click(object sender, EventArgs e)//При нажатии на кнопку 18(del)
        {
            int lenght = textBox1.Text.Length - 1;//Вводим новую переменную lenght целочисленного типа и записываем в неё количество символов в TextBox’e минус один символ.
            string text = textBox1.Text;//Также мы вводим новую переменную text, в которую полностью заносим текст из TextBox’а
            textBox1.Clear();//Очищаем TextBox
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];//Записываем в TextBox строку text, но уже на символ короче
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "+-0")//Если в поле вывода строка равна +-0
            {
                textBox3.Text = "0";//То заменяем её на строку 0
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//Когда пользователь нажимает любую кнопку в поле для введение подкоренного выражения
        {
            char number = e.KeyChar;//Объявляем символьную переменную под названием char
            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 45) //Если символ из переменной number не относится к категории десятичных цифр или клавише BackSpace или точку или минусу
            {
                e.Handled = true;//Тогда не обрабатывать введенный символ
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)//Когда пользователь нажимает любую кнопку в поле для введения кол-ва знаков полсе запятой
        {
            char number = e.KeyChar;//Объявляем символьную переменную под названием char
            if (!Char.IsDigit(number) && number != 8) //Если символ из переменной number не относится к категории десятичных цифр или клавише BackSpace
            {
                e.Handled = true;//Тогда не обрабатывать введенный символ
            }
        }
    }
}
