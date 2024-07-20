namespace _20._07._2024_orn7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int rowIndex = 0; // 0-based indexing, so 1st row is 0, 3rd row is 2

            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is Button button)
                {
                    if (i % 3 == 0)
                    {
                        button.BackColor = Color.Blue;
                    }
                    else if (i % 3 == 2)
                    {
                        button.BackColor = Color.Red;
                    }
                    else if (i % 3 == 1)
                    {
                        button.BackColor = Color.Purple;
                    }
                    else
                    {
                        button.BackColor = SystemColors.Control; // reset to default color
                    }
                }
            }
        }
    }
}
