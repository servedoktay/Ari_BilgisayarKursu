namespace _21._07._2024_orn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //kodla nesne uretmek

            Button a = new Button();
            a.Text = "OK";
            a.BackColor = Color.Red;
            a.Left = 50;
            a.Top = 120;

            this.Controls.Add(a);

            ListBox b = new ListBox();
            b.Items.Add("elma");
            b.Items.Add("armut");

            this.Controls.Add(b);

           
        }

      
    }
}
