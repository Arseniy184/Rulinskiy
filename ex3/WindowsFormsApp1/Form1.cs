using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            try
            {
                if (Convert.ToInt32(number) < 11 && Convert.ToInt32(number) > 0)
                {
                    Form2 newForm = new Form2(Convert.ToInt32(number));
                    newForm.Show();
                }
                else
                {
                    textBox2.Text = "Введите число от 1 до 10";
                }
            }
            catch (Exception ex)
            {
                textBox2.Text = $"Исключение: {ex.Message}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
