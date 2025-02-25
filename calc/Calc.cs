﻿using System.Data;
using System.Drawing; // Для Рандомной Смены Цвета (Вырезано В Этом Билде)

namespace calc
{
    public partial class Calc : Form
    {
        private Button[] buttons; // Массив кнопок
        public Calc()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Инициализация массива кнопок
            buttons = new Button[] { button1, button2, button3, button4, button5,
                              button6, button7, button8, button9, button10,
                              button11, button12, button13, button14, button15,
                              button16, button17, button18, button19, button20, };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            if (currentButton != null) // Проверка на null
            {
                textBox1.Text += currentButton.Text;
            }
            else
            {
                // Обработка случая, если sender не является Button
                MessageBox.Show("Ошибка: sender не является кнопкой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var d = new DataTable();
            try
            {
                textBox1.Text = d.Compute(textBox1.Text, "").ToString();
            }

             // Обработка ошибки

            catch (EvaluateException)
            {
                MessageBox.Show("Error: Expression cannot be evaluated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unknown error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
        }

        private void Clear(object sender, EventArgs e)  // Очищает колхозно наш текст бокс на один символ
        {
            var str = "";
            for (int i = 0; i < textBox1.Text.Length - 1; i++)
            {
                str += textBox1.Text[i];
            }
            textBox1.Text = str;
        }

        private void ClearC(object sender, EventArgs e)  // Не менее колхозно убирает текст полностью
        {
            textBox1.Text = "";
        }

        //Ниже рандомные цвета если вы смотрите данный чудокод можете раскоментировать (В Данном Билде Это Вырезано)

        /*
        private void randomColor_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            foreach (var button in buttons)
            {
                button.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            }
            textBox1.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        */



        //ЧЕРНАЯ ТЕМА

        private void Black(object sender, EventArgs e)  // Меняем цвет фона формы на черный
        {
            foreach (var button in buttons)
            {   
                this.BackColor = Color.DarkGray;

                button.BackColor = Color.WhiteSmoke; // Меняем цвет всех кнопок на черный
            }
            textBox1.BackColor = Color.WhiteSmoke; // Также меняем цвет текстового поля
        }

        //БЕЛАЯ ТЕМА

        private void White(object sender, EventArgs e)  // Меняем цвет фона формы на белый
        {
            foreach (var button in buttons)
            {
                
                this.BackColor = Color.White;

                button.BackColor = Color.White; // Меняем цвет всех кнопок на белый
            }
            textBox1.BackColor = Color.WhiteSmoke; // Также меняем цвет текстового поля
        }
    }
}
