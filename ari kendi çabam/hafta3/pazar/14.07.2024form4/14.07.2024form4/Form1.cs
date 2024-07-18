using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._07._2024form4
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
       
private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add("selam");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //inverval=milisaniye;
            timer1.Start();
        }
    }

}
