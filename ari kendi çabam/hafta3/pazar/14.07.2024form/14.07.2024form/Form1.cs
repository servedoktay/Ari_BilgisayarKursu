using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._07._2024form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show("Selam");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show(textBox1.Text);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int s1, s2, enb, enk;
            s1 = Convert.ToInt32(txtgirilensayi1.Text);
            s2 = Convert.ToInt32(txtgirilensayi2.Text);
            enb = Math.Max(s1, s2);
            enk = Math.Min(s1, s2);

            if (s1 == s2)
            {
                MessageBox.Show("Değer Aralığı yoktur");
                return; // Aralık yoksa çık
            }

            for (int i = enk; i < enb; i++)
            {
                if (asalkontrol(i))
                {
                    listBox1.Items.Add(i);
                }
            }




        }
        private static bool asalkontrol(int sayi)
        {
            if (sayi < 2) return false; // 0 ve 1 asal sayı değildir
            for (int i = 2; i <= sayi / 2; i++)
            {
                if (sayi % i == 0)
                {
                    return false; // asal sayı değil
                }
            }
            return true; // asal sayı
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s1, s2, ort;
            s1=Convert.ToInt32(textBox3.Text);
            s2=Convert.ToInt32(textBox2.Text);
            ort = (s1 + s2)/ 2;
            label3.Text = ort.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double taban, kenar1, kenar2, h, cevre, alan;
            kenar1= Convert.ToInt32(textBox5.Text);
            kenar2= Convert.ToInt32(textBox4.Text);
            taban= Convert.ToInt32(textBox6.Text);
            h=Convert.ToInt32(textBox7.Text);
            cevre=taban+kenar1+kenar2;
            alan = (taban * h) / 2;
            MessageBox.Show($"Ucgenin cevresi{cevre}\nUcgenin Alani={alan}");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
