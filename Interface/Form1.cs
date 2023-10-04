using static Lib.Utils;
namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox2.Text == "")
            {
                MessageBox.Show("Пустое поле");
                return;
            }
            try
            {
                string n1 = richTextBox1.Text;
                string n2 = richTextBox2.Text;
                richTextBox3.Text = AddBig(n1, n2);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox2.Text == "")
            {
                MessageBox.Show("Пустое поле");
                return;
            }
            try
            {
                string n1 = richTextBox1.Text;
                string n2 = richTextBox2.Text;
                richTextBox3.Text = MinusBig(n1, n2);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox2.Text == "")
            {
                MessageBox.Show("Пустое поле");
                return;
            }
            try
            {
                string n1 = richTextBox1.Text;
                string n2 = richTextBox2.Text;
                richTextBox3.Text = MultiplyBig(n1, n2);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox2.Text == "")
            {
                MessageBox.Show("Пустое поле");
                return;
            }
            try
            {
                string n1 = richTextBox1.Text;
                string n2 = richTextBox2.Text;
                richTextBox3.Text = DivideBig(n1, n2);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            labelNum1.Text = "Длина строки: " + richTextBox1.Text.Length.ToString();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            labelNum2.Text = "Длина строки: " + richTextBox2.Text.Length.ToString();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            labelResult.Text = "Длина строки: " + richTextBox3.Text.Length.ToString();
        }
    }
}