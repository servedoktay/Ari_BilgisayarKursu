namespace _20._07._2024_orn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbMeyveler.Items.Add(txtEklenecek.Text);
            txtEklenecek.Clear();
        }
    }
}
