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

        public static String result(String number)
        {
            String str = "";
            if (Convert.ToInt32(number) > 7)
            {
                str = "Привет";
            }
            else if (Convert.ToInt32(number) < 7)
            {
                str = "Число меньше 7";
            }
            else if (Convert.ToInt32(number) == 7)
            {
                str = "Вы ввели 7";
            }
            return str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            try
            {
                textBox2.Text = result(number);
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
    }
}
