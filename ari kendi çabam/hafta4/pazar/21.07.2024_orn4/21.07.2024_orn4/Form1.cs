namespace _21._07._2024_orn4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //kodla olusturulan nesnelerin clickleri
            Button btn=new Button();
            btn.Text = "Selam";
            btn.BackColor = Color.Red;
            btn.Click += Btn_Click;
            this.Controls.Add(btn); 
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Selam");
        }
    }
}
