using QRCoder;

namespace _20._07._2024_orn4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qrText =textBox1.Text.Trim();

            // QR kod olu�turma i�lemi
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10); // QR kodunun g�rselini olu�tur

            // PictureBox'a QR kodunu g�ster
            pictureBox1.Image = qrCodeImage;
        }
    }
}
