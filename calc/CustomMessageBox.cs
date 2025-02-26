using System;
using System.Drawing;
using System.Windows.Forms;

namespace calc
{
    public partial class CustomMessageBox : Form
    {
        // Конструктор формы
        public CustomMessageBox(string message, string caption, MessageBoxIcon icon)
        {
            InitializeComponent();

            // Устанавливаем заголовок и текст сообщения
            this.Text = caption;
            labelMessage.Text = message;

            // Настройка иконки
            switch (icon)
            {
                case MessageBoxIcon.Information:
                    this.Icon = SystemIcons.Information; // Иконка информации
                    break;
                case MessageBoxIcon.Error:
                    this.Icon = SystemIcons.Error; // Иконка ошибки
                    break;
                case MessageBoxIcon.Question:
                    this.Icon = SystemIcons.Question; // Иконка вопроса
                    break;
                case MessageBoxIcon.Exclamation:
                    this.Icon = SystemIcons.Exclamation; // Иконка предупреждения
                    break;
            }
        }

        // Обработчик нажатия на кнопку "OK"
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрываем форму
        }
    }
}