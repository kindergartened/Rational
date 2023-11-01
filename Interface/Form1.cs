using Lib;
using System.Numerics;
using static Lib.Utils;
namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button5_Click(object sender, EventArgs e)
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
                BigInt num1 = new BigInt(n1);
                BigInt num2 = new BigInt(n2);
                richTextBox3.Text = (num1 % num2).ToString();
            }
            catch (Exception Error)
            {
                MessageBox.Show("Ошибка:" + Error.Message);
            }
        }

        private void additionBtn_Click(object sender, EventArgs e)
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
                richTextBox3.Text = (num1 + num2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
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
                richTextBox3.Text = (num1 * num2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void divideBtn_Click(object sender, EventArgs e)
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
                richTextBox3.Text = (num1 / num2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void substractBtn_Click(object sender, EventArgs e)
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
                richTextBox3.Text = (num1 - num2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}