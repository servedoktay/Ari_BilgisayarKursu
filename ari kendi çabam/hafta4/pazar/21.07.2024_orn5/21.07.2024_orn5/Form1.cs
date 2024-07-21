using QRCoder;
using System.Windows.Forms;

namespace _21._07._2024_orn5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox pic1 = new PictureBox();
        TextBox text = new TextBox();
        private void Form1_Load(object sender, EventArgs e)
        {
         
            pic1.Top = 25 ;
            pic1.Left = 40;
            pic1.SizeMode= PictureBoxSizeMode.StretchImage;
            pic1.Size=new Size(169,176);
            this.Controls.Add(pic1);    

            
            text.Top = 35;
            text.Left = 245;
            this.Controls.Add(text);

            Button bas=new Button();
            bas.Text = "Olustur";
            bas.Top = 75;
            bas.Left = 245;
            this.Controls.Add (bas);

            bas.Click += Bas_Click;
        }

        private void Bas_Click(object? sender, EventArgs e)
        {
            string qrText = text.Text.Trim();

            // QR kod oluþturma islemi
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10); // QR kodunun görselini oluþtur

            // PictureBox'a QR kodunu göster
            pic1.Image = qrCodeImage;
        }
    }
}
