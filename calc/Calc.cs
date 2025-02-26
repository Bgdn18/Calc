using System.Data;
using System.Drawing; // Для Рандомной Смены Цвета (Вырезано В Этом Билде)

namespace calc
{
    public partial class Calc : Form
    {
        private void ShowRandomMessageBox(Random rand)
        {
            // Генерация случайных координат
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int x = rand.Next(0, screenWidth - 300); // 300 - примерная ширина MessageBox
            int y = rand.Next(0, screenHeight - 150); // 150 - примерная высота MessageBox

            // Создание и отображение CustomMessageBox
            var customMessageBox = new CustomMessageBox("ВАША ЖОПА БЫЛА ВЗЛОМАНА", "ВНИМАНИЕ!!!", MessageBoxIcon.Error);
            customMessageBox.StartPosition = FormStartPosition.Manual; // Устанавливаем положение вручную
            customMessageBox.Location = new Point(x, y); // Задаем случайные координаты
            customMessageBox.Show(); // Показываем форму
        }

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
                              button16, button17, button18, button19, button20,
                              button21, button22,button23,button24,button25,
                              button26,button27,button28,button29,button30};
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

        /*Ниже кнопка темы на рандомный цвет при нажатии 
            если вы смотрите данный чудокод можете
        раскоментировать и использовать в дальнейшем */

        /**/
        private async void randomColor_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            DateTime startTime = DateTime.Now; // Запоминаем время начала
            int delay = 1000; // Начальная задержка 1000 мс

            // Цикл выполняется в течение 15 секунд
            while ((DateTime.Now - startTime).TotalSeconds < 15)
            {
                foreach (var button in buttons)
                {
                    button.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                }
                textBox1.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                // Задержка с текущим значением delay
                await Task.Delay(delay);

                // Уменьшаем задержку в 2 раза
                delay /= 2;

                // Если задержка стала слишком маленькой, устанавливаем минимальное значение
                if (delay < 10) // Минимальная задержка 10 мс
                {
                    delay = 10;
                }

                // Пасхалка: показ сообщений в случайных местах
                if ((DateTime.Now - startTime).TotalSeconds < 10)
                {
                    // Запускаем несколько сообщений одновременно
                    for (int i = 0; i < 5; i++)
                    {
                        ShowRandomMessageBox(rand);
                    }
                }
            }

            // После завершения цикла ждем и закрываем приложение
            await Task.Delay(0); // Ждем
            Application.Exit(); // Закрываем приложение
        }//EASTER EGG





        //ЧЕРНАЯ ТЕМА

        private void Blue(object sender, EventArgs e)  // Меняем цвет фона формы на черный
        {
            foreach (var button in buttons)
            {
                this.BackColor = Color.LightSteelBlue;

                button.BackColor = Color.SteelBlue; // Меняем цвет всех кнопок на черный
            }
            textBox1.BackColor = Color.SteelBlue; // Также меняем цвет текстового поля
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Проверяем содержит ли textBox текст "1812"
            if (textBox1.Text == "1812")
            {
                // Если да делаем пасхалку видимой
                EasterEgg.Visible = true;
            }
            else
            {
                // Если нет скрываем пасхалку
                EasterEgg.Visible = false;
            }
        }
    }
}
