using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._07._2024form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //secilen list box degıskenınını ters cevırıp yazma
            listBox1.Items.Add(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

            }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin = listBox1.SelectedItem.ToString();
            int index = listBox1.SelectedIndex;
            string yeniMetin = "";
            //listBox1.Items.Remove(listBox1.SelectedItem.ToString());
            for (int i = metin.Length - 1; i > -1; i--)
            {
                yeniMetin += metin[i].ToString();                
            }
            //listBox1.Items.Add(yeniMetin);
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index, yeniMetin);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string reversed = new string(input.Reverse().ToArray());
            
            MessageBox.Show("Reversed string: " + reversed);
        }
    }
}
