using Lib;
using static Lib.BigInt;
using static Lib.Rational;
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
            if (richTextBox1.Text=="" || richTextBox2.Text=="")
            {
                MessageBox.Show("������ ����");
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
                MessageBox.Show("������");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox2.Text == "")
            {
                MessageBox.Show("������ ����");
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
                MessageBox.Show("������");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox2.Text == "")
            {
                MessageBox.Show("������ ����");
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
                MessageBox.Show("������");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox2.Text == "")
            {
                MessageBox.Show("������ ����");
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
                MessageBox.Show("������");
            }
        }
    }
}