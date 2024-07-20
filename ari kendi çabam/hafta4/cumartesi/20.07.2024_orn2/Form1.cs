namespace _20._07._2024_orn2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tarih1 = dtpTarih1.Value;
            DateTime tarih2 = dtpTarih2.Value;

            // Tarihler aras�ndaki y�l, ay ve g�n farklar�n� hesaplayal�m
            int yilFark = tarih1.Year - tarih2.Year;
            int ayFark = tarih1.Month - tarih2.Month;
            int gunFark = tarih1.Day - tarih2.Day;

            // Negatif farklar� d�zeltmek i�in kontrol yapal�m
            if (gunFark < 0)
            {
                // �nceki ay�n g�n say�s�n� alarak g�n fark�n� d�zeltelim
                DateTime oncekiAyTarihi = tarih1.AddMonths(-1);
                gunFark += DateTime.DaysInMonth(oncekiAyTarihi.Year, oncekiAyTarihi.Month);
                ayFark--; // Ay fark�n� da d�zeltelim
            }

            if (ayFark < 0)
            {
                yilFark--;
                ayFark += 12; // 12 ay = 1 y�l
            }

            // Sonucu g�n cinsinden hesaplayal�m
            int fark = yilFark * 365 + ayFark * 30 + gunFark;
            MessageBox.Show("Toplam g�n fark�: " + fark.ToString());



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime tarih1 = dtpTarih1.Value;
            DateTime tarih2 = dtpTarih2.Value;

            TimeSpan ts = tarih2 - tarih1;
            int gunFark = ts.Days;

            MessageBox.Show("Tarihler aras�ndaki g�n fark�: " + gunFark.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpTarih1.Value.ToLongDateString());
        }
    }
}
