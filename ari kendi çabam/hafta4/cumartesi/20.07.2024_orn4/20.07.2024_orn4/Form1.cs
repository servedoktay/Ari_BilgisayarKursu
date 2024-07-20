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

            // QR kod oluþturma iþlemi
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10); // QR kodunun görselini oluþtur

            // PictureBox'a QR kodunu göster
            pictureBox1.Image = qrCodeImage;
        }
    }
}
