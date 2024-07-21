namespace _21._07._2024_orn3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] btndizi = new Button[5, 5];

            
            int buttonSize = 25;  // Button'larýn boyutu
            int horizontalSpacing = 30;  // Yatay boþluk miktarý
            int verticalSpacing = 35;    // Dikey boþluk miktarý

            for (int i = 0; i < 5; i++)   // Satýrlar için döngü
            {
                for (int j = 0; j <= i; j++)   // Sütunlar için döngü, her satýrda sütun sayýsý artar
                {
                    btndizi[i, j] = new Button();
                    btndizi[i, j].Text = "";
                    btndizi[i, j].Size = new Size(buttonSize, buttonSize);
                    btndizi[i, j].BackColor = Color.Red;
                    btndizi[i, j].Left = horizontalSpacing * j;   // Sütun numarasýna baðlý olarak yatay pozisyon ayarlanýr
                    btndizi[i, j].Top = verticalSpacing * i;      // Satýr numarasýna baðlý olarak dikey pozisyon ayarlanýr

                    groupBox2.Controls.Add(btndizi[i, j]);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
