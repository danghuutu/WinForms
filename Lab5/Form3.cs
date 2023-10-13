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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "";
            if (checkBox1.Checked == true)
            {
                str = checkBox1.Text + "\n";
            }
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text + "\n";
            }
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text + "\n";
            }
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text + "\n";
            }
            if (checkBox5.Checked == true)
            {
                str = str + checkBox5.Text;
            }
            if (str.Length > 0)
            {
                MessageBox.Show("Sở thích của bạn là: \n" + str);
            }
            else
            {
                MessageBox.Show("Không có sở thích nào bạn chọn!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            if(radioButton1.Checked == true)
            {
                str = radioButton1.Text + "\n";
            }
            if(radioButton2.Checked == true)
            {
                str = radioButton2.Text + "\n";
            }
            if ((radioButton3.Checked == true))
            {
                str = radioButton3.Text + "\n";
            }
            if ((radioButton4.Checked == true))
            {
                str = radioButton4.Text + "\n";
            }
            if ((radioButton5.Checked == true))
            {
                str = radioButton5.Text;
            }
            if (str.Length > 0)
            {
                MessageBox.Show("Màu bạn thích là: \n" + str);
            }
            else
            {
                MessageBox.Show("Không có màu nào bạn chọn!!!");
            }
        }
    }


    class Program_Checkbox_RadioButton
    {
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form3());
        }
    }
}
