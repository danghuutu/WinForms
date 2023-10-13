using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab5.Form4;

namespace Lab5
{

    public partial class Form4 : Form
    {
        public class HocSinh
        {
            public string HoTen { get; set; }
            public double DiemToan { get; set; }
            public double DiemLy { get; set; }
            public double DiemHoa { get; set; }

            public HocSinh(string hoTen, double diemToan, double diemLy, double diemHoa)
            {
                HoTen = hoTen;
                DiemToan = diemToan;
                DiemLy = diemLy;
                DiemHoa = diemHoa;
            }
        }

        private List<HocSinh> danhSachHocSinh = new List<HocSinh>();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hoTen = textBox1.Text;
            double diemToan = Convert.ToDouble(textBox2.Text);
            double diemLy = Convert.ToDouble(textBox3.Text);
            double diemHoa = Convert.ToDouble(textBox4.Text);

            HocSinh hocSinh = new HocSinh(hoTen, diemToan, diemLy, diemHoa);
            danhSachHocSinh.Add(hocSinh);

            MessageBox.Show("Đã thêm học sinh " + hoTen + " vào danh sách.");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "";
            for (int i = 0; i < danhSachHocSinh.Count; i++)
            {
                message += "Sinh vien " + (i + 1) + ": " + danhSachHocSinh[i].HoTen + ", "
                    + danhSachHocSinh[i].DiemToan + ", " + danhSachHocSinh[i].DiemLy + ", "
                    + danhSachHocSinh[i].DiemHoa+ "\n";
            }
            MessageBox.Show(message);
        }
    }

    class Program_ListHocSinh
    {
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form4());
        }
    }
}
