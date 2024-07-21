namespace _21._07._2024_orn7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Tus Yukarýda");
            //tus yukarý kalktýgýnda
            if (e.KeyCode == Keys.Y)
            {
                MessageBox.Show("Sadece y tusuna basýlýnca ");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Tus basýldý");
            //basýldýgýnda olucak olaylar



        }

        private void button1_BackColorChanged(object sender, EventArgs e)
        {
            //arka plan rengi degistiginde 
            MessageBox.Show($"Arka plan rengi degisti   {button1.BackColor.ToString()}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }
    }
}
