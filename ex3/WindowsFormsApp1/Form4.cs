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
    public partial class Form4 : Form
    {
        List<int> array = new List<int>();
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            try
            {
                if (Convert.ToInt32(number) < 100 && Convert.ToInt32(number) > 0)
                {
                    array.Add(Convert.ToInt32(number));
                    textBox4.Text = string.Join("\n ", array);
                    textBox2.Text = " ";
                }
                else
                {
                    textBox2.Text = "Введите число от 1 до 99";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public List<int> resultArray(List<int> array)
        {
            List<int> result = new List<int>();
            foreach (int var in array)
            {
                if (var % 3 == 0)
                {
                    result.Add(var);
                }

            }
            return result;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Join("\n ", resultArray(array)); ;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
