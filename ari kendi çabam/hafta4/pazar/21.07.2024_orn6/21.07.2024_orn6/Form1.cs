namespace _21._07._2024_orn6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //keydown=assag�ya bas�ld�g�nda cal�s�cak kodlar
            if (e.KeyData == Keys.Enter)
            {
                MessageBox.Show(textBox1.Text);//enter giris yap�ld�g�nda 
            }
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("�zerinde");
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("ayr�ld�");

        }
    }
}
