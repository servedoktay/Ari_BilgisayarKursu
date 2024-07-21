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

            
            int buttonSize = 25;  // Button'lar�n boyutu
            int horizontalSpacing = 30;  // Yatay bo�luk miktar�
            int verticalSpacing = 35;    // Dikey bo�luk miktar�

            for (int i = 0; i < 5; i++)   // Sat�rlar i�in d�ng�
            {
                for (int j = 0; j <= i; j++)   // S�tunlar i�in d�ng�, her sat�rda s�tun say�s� artar
                {
                    btndizi[i, j] = new Button();
                    btndizi[i, j].Text = "";
                    btndizi[i, j].Size = new Size(buttonSize, buttonSize);
                    btndizi[i, j].BackColor = Color.Red;
                    btndizi[i, j].Left = horizontalSpacing * j;   // S�tun numaras�na ba�l� olarak yatay pozisyon ayarlan�r
                    btndizi[i, j].Top = verticalSpacing * i;      // Sat�r numaras�na ba�l� olarak dikey pozisyon ayarlan�r

                    groupBox2.Controls.Add(btndizi[i, j]);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
