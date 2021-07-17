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
    public partial class Form3 : Form
    {
        private int number;
        private int[] array;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(int number)
        {
            InitializeComponent();
            this.number = number;
            this.array = new int[this.number];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public List<int> resultArray(int[] array)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
            textBox1.Text = string.Join("\n ", array);
            textBox2.Text = string.Join("\n ", resultArray(array)); ;
        }
    }
}
