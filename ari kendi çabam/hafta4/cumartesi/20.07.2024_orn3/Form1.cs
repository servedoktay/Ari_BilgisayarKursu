using System.Windows.Forms;

namespace _20._07._2024_orn3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private OpenFileDialog openFileDialog1;
        private ImageList imageList1;
        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            imageList1 = new ImageList();
        }

        private void btnFotosec_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "Resim Dosyalarý (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tüm Dosyalar (*.*)|*.*";
            openFileDialog1.Multiselect = true; 

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int genislik = 1400; 
                int yukseklik = 1300;

                foreach (string dosyaYolu in openFileDialog1.FileNames)
                {
                    Image image = Image.FromFile(dosyaYolu);
                    Image resizedImage = new Bitmap(image, genislik, yukseklik);
                    imageList1.Images.Add(resizedImage);
                }

               
                pictureBox1.Image = imageList1.Images[imageList1.Images.Count - 1];
            }
        }
        private int currentImageIndex = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 0)
            {
                pictureBox1.Image = imageList1.Images[currentImageIndex];
                currentImageIndex++;

                if (currentImageIndex >= imageList1.Images.Count)
                {
                    currentImageIndex = 0; 
                }
            }

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 0)
            {
                currentImageIndex--;
                if (currentImageIndex < 0)
                {
                    currentImageIndex = imageList1.Images.Count - 1; // Son resme gitmek için
                }
                pictureBox1.Image = imageList1.Images[currentImageIndex];
            }
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 0)
            {
                currentImageIndex++;
                if (currentImageIndex >= imageList1.Images.Count)
                {
                    currentImageIndex = 0; // Ýlk resme dönmek için
                }
                pictureBox1.Image = imageList1.Images[currentImageIndex];
            }
        }
    }
}
