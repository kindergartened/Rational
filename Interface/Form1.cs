using Lib;
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
                BigInt num1 = new(n1);
                BigInt num2 = new(n2);
                if (num1 > num2)
                    richTextBox3.Text = MinusBig(n1, n2).TrimStart('0');
                else if (num1 == num2)
                    richTextBox3.Text = "0";
                else
                    richTextBox3.Text ="-"+MinusBig(n2, n1).TrimStart('0');
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
            catch (Exception Error)
            { 
                MessageBox.Show("Ошибка:"+ Error.Message);
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