namespace _20._07._2024_orn6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach(Button item in groupBox1.Controls)
            {
                item.BackColor = Color.Blue;
            }
        }
    }
}
