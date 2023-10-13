using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox4.Text); ;
            textBox6.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox4.Text); ;
            textBox6.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox4.Text); ;
            textBox6.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(textBox2.Text) / Convert.ToDouble(textBox4.Text);
            textBox6.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox4.Clear();
            textBox6.Clear();
        }
    }

    class Program_Operations
    {
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form2());
        }
    }
}
