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
            ben�myol();
            //cozum2();
            //GroupBox grp=new GroupBox();
            //grp.Text = "Butonlardaan Ucgen";
            //grp.Height = 200;
            //grp.Width = 200;
            //grp.BackColor = Color.White;
        }

        private void ben�myol()
        {
            Button[,] btndizi = new Button[5, 5];

            

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    btndizi[i, j] = new Button();
                    btndizi[i, j].Text = "";
                    btndizi[i, j].Size = new Size(25, 25);
                    btndizi[i, j].BackColor = Color.Red;
                    btndizi[i, j].Left = 20 * (j + 1); //yandan yana 
                    btndizi[i, j].Top = 30 * (i + 1); //yukar�dan assag�ya

                    groupBox2.Controls.Add(btndizi[i, j]);
                }
            }
        }

        private static void cozum2()
        {
            Button[,] btndizi = new Button[5, 5];

            //int buttonSize = 25;  
            //int horizontalSpacing = 30;  // Yatay bo�luk miktar�
            //int verticalSpacing = 35;    // Dikey bo�luk miktar�

            //for (int i = 0; i < 5; i++)   // Sat�rlar i�in d�ng�
            //{
            //    for (int j = 0; j <= i; j++)   // S�tunlar i�in d�ng�, her sat�rda s�tun say�s� artar
            //    {
            //        btndizi[i, j] = new Button();
            //        btndizi[i, j].Text = "";
            //        btndizi[i, j].Size = new Size(buttonSize, buttonSize);
            //        btndizi[i, j].BackColor = Color.Red;
            //        btndizi[i, j].Left = horizontalSpacing * j;  
            //        btndizi[i, j].Top = verticalSpacing * i;    

            //        groupBox2.Controls.Add(btndizi[i, j]);
            //    }
            //}
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
