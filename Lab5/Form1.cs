namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this program?", "Ask the user",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) ;
            //Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Name: " + textBox1.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this program?", "Ask the user",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)
            {
                textBox1.Text = "Hello FPT University";
            }
        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("You just clicked the right mouse");
            }
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("You just clicked the left mouse");
            }
        }
    }

    class Program_ShowName
    {
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}