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
    public partial class Form2 : Form
    {
        private int number;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int number)
        {
            InitializeComponent();
            this.number = number;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(number);
            newForm.Show();
            this.Close();
        }
    }
}
