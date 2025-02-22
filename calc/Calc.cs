using System.Data;

namespace calc
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
            // Запрет изменения размера окна
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; // Убираем кнопку максимизации
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            textBox1.Text += currentButton.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var d = new DataTable();
            try
            {
                textBox1.Text = d.Compute(textBox1.Text, "").ToString();
            }

            /* Обработка ошибки в случае деления на буквы */

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

        private void Clear(object sender, EventArgs e)
        {
            var str = "";
            for (int i = 0; i < textBox1.Text.Length - 1; i++)
            {
                str += textBox1.Text[i];
            }
            textBox1.Text = str;
        }

        private void ClearC(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
