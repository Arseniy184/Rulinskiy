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

        public static String resultSearch(String name)
        {
            String result = name.ToLower();
            if (Equals(result, "вячеслав"))
            {
                result = "Привет, Вячеслав";
            }
            else
            {
                result = "Нет такого имени";
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            try
            {
                textBox2.Text = resultSearch(name);
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
