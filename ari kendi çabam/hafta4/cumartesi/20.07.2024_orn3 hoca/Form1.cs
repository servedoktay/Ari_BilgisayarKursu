namespace _20._07._2024_orn3_hoca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Multiselect = true;
            listBox1.Items.Add(openFileDialog1.FileName.ToString());

            /*foreach (string fileName in openFileDialog1.FileNames) //coklu secým icin
    {
            listBox1.Items.Add(fileName);
    }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count<=0)
            {
                MessageBox.Show("Hata Resim Secin");
                return;
            }
            timer1.Start();
        }
        int say = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = listBox1.Items[say].ToString();

            if (listBox1.Items.Count - 1 > say) //4 olmamasý ýcýn 
            {
                say++;
            }
            else
            {
                say = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                say++;
                if (say >= listBox1.Items.Count)
                {
                    say = 0; 
                }
                pictureBox1.ImageLocation = listBox1.Items[say].ToString();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                say--;
                if (say >= listBox1.Items.Count|| say<0)
                {
                    say = 0; 
                }
             
                pictureBox1.ImageLocation = listBox1.Items[say].ToString();
                
            }
        }
    }
}
