using System;
using System.Windows.Forms;
namespace lr_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
            double A = random.Next(1, 100);
            double B = random.Next(1, (int)A);
            textBox1.Text = A.ToString();
            textBox2.Text = B.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double A, B;
            if (double.TryParse(textBox1.Text, out A) && double.TryParse(textBox2.Text, out B))
            {
                if (A > B)
                {
                    double temp = A;
                    A = B;
                    B = temp;
                }
                textBox3.Text = A.ToString();
                textBox4.Text = B.ToString();
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення!");
            }
        }
    }
}