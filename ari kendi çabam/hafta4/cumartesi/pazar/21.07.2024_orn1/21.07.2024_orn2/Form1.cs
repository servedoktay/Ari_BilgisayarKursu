namespace _21._07._2024_orn2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] btndizi = new Button[10];
            
            for (int i = 0; i < btndizi.Length; i++)
            {
                btndizi[i] = new Button();
                btndizi[i].Text = "Ankara";
                btndizi[i].BackColor= Color.Green;
                btndizi[i].Top = 25 * i;
                btndizi[i].Left=40;

                this.Controls.Add(btndizi[i]);
            }
        }
    }
}
