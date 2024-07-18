using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir mağazanın datalarını tutabilecek bir class oluşturunuz. Bu class içerisinde müşteri, satışlar, stoklar, personeller gibi datalar tutulmalıdır. fonksiyon ile depo da ne kadar ürün var, bugün ne kadar satıldı, t tarihinde ne kadar satıldı, hangi personel ne kadar ürün sattı gibi değerlerin fonksiyon üzerinden dönmesi beklenmektedir.

            Personeller yeniper = new Personeller();
            yeniper.Id= 1;

            Satislar yenisatis = new Satislar();
            yenisatis.Id = 0;
            yenisatis.personelId.Id = 1;


        }

        class Musteri
        {
            public int Id { get; set; }
            public string adSoyad { get; set; }
            public DateTime kayitTarihi { get; set; }          

        }
        class Satislar
        {            
            public int Id { get; set; }
            public string Urunadi { get; set; }
            public Personeller personelId { get; set; }
            public int satisMiktari { get; set; }
            public Musteri musteriId { get; set; }

            int satisDurum()
            {
                return satisMiktari;

            }
        }
        class Personeller
        {
            public int Id { get; set; }
            public string adSoyad { get; set; }
        }
        class Stoklar
        {
            public int Id { get; set; }
            public string stokAdi { get; set; }
            public int stokMiktari { get; set; }

            int stokDurumu()
            {
                return stokMiktari; 
            }
        }
    }
}
