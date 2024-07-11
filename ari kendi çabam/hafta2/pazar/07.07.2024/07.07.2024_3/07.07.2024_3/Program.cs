using System;

namespace _07._07._2024_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir hastanenin class yapısını olusturunuz class icerisinde hastalar doktorlar hemşireler hastabilgileri öğrenciler çalışanlar ,stajyerler gibi dataların tutuldugu yapıda olmalıdır.hasta miktari kullandıgı ilaçlar gibi datalarıda fonksiyon ile sorgulaya biliriz
            Bolumler bolum1 = new Bolumler();
            bolum1.BolumId = 0;
            bolum1.BolumAD = "Acil";

            Bolumler bolum2 = new Bolumler();
            bolum2.BolumId = 1;
            bolum2.BolumAD = "Dahiliye";

            Bolumler bolum3 = new Bolumler();
            bolum3.BolumId = 2;
            bolum3.BolumAD = "Cerrahi";

            // Doktorlar oluşturuluyor
            Doktorlar doktor1 = new Doktorlar();
            doktor1.doktorID = 0;
            doktor1.doktorAd = "Osman";
            doktor1.Bolumu = bolum1;

            Doktorlar doktor2 = new Doktorlar();
            doktor2.doktorID = 1;
            doktor2.doktorAd = "Şükrü";
            doktor2.Bolumu = bolum2;

            Doktorlar doktor3 = new Doktorlar();
            doktor3.doktorID = 2;
            doktor3.doktorAd = "Akif";
            doktor3.Bolumu = bolum2;

            // Hemşireler oluşturuluyor
            Hemsireler hemsire1 = new Hemsireler();
            hemsire1.hemsireID = 0;
            hemsire1.hemsireAd = "EYLUL";
            hemsire1.Bolumu = bolum1;

            Hemsireler hemsire2 = new Hemsireler();
            hemsire2.hemsireID = 1;
            hemsire2.hemsireAd = "HATİCE";
            hemsire2.Bolumu = bolum2;

            Hemsireler hemsire3 = new Hemsireler();
            hemsire3.hemsireID = 2;
            hemsire3.hemsireAd = "LEYLA";
            hemsire3.Bolumu = bolum3;

            // Stajyerler oluşturuluyor
            Stajyerler stj1 = new Stajyerler();
            stj1.stajyerID = 0;
            stj1.stajyerAd = "Ali";
            stj1.Bolumu = bolum1;

            Stajyerler stj2 = new Stajyerler();
            stj2.stajyerID = 1;
            stj2.stajyerAd = "Veli";
            stj2.Bolumu = bolum1;

            Stajyerler stj3 = new Stajyerler();
            stj3.stajyerID = 2;
            stj3.stajyerAd = "Tarık";
            stj3.Bolumu = bolum1;

            // Hastalar oluşturuluyor
            Hastalar hasta1 = new Hastalar();
            hasta1.hastaID = 0;
            hasta1.hastaAd = "A";

            Hastalar hasta2 = new Hastalar();
            hasta2.hastaID = 1;
            hasta2.hastaAd = "B";

            Hastalar hasta3 = new Hastalar();
            hasta3.hastaID = 2;
            hasta3.hastaAd = "C";

            Hastalar hasta4 = new Hastalar();
            hasta4.hastaID = 3;
            hasta4.hastaAd = "D";

            Hastalar hasta5 = new Hastalar();
            hasta5.hastaID = 4;
            hasta5.hastaAd = "E";

            // Hasta kayıtları oluşturuluyor
            hastaKayit kayit1 = new hastaKayit();
            kayit1.kayit = 0;
            kayit1.hasta = hasta2;          // hasta2 atanıyor
            kayit1.bolumu = bolum3;         // bolum3 atanıyor
            kayit1.doktoru = doktor3;       // doktor3 atanıyor
            kayit1.hemsireler = hemsire3;   // hemsire3 atanıyor
            kayit1.kayitT = DateTime.Now;

            hastaKayit kayit2 = new hastaKayit();
            kayit2.kayit = 1;
            kayit2.hasta = hasta1;          // hasta1 atanıyor
            kayit2.bolumu = bolum2;         // bolum2 atanıyor
            kayit2.doktoru = doktor2;       // doktor2 atanıyor
            kayit2.hemsireler = hemsire2;   // hemsire2 atanıyor
            kayit2.kayitT = DateTime.Now;

            hastaKayit kayit3 = new hastaKayit();
            kayit3.kayit = 2;
            kayit3.hasta = hasta3;          // hasta3 atanıyor
            kayit3.bolumu = bolum1;         // bolum1 atanıyor
            kayit3.doktoru = doktor1;       // doktor1 atanıyor
            kayit3.hemsireler = hemsire1;   // hemsire1 atanıyor
            kayit3.kayitT = DateTime.Now;

            // İlaçlar oluşturuluyor
            ilaclar i1 = new ilaclar();
            i1.ilacID = 0;
            i1.ilacAd = "Parol";

            ilaclar i2 = new ilaclar();
            i2.ilacID = 1;
            i2.ilacAd = "Aspirin";

            // Kullanılan ilaçlar oluşturuluyor
            kullanilanIlaclar kullanilan1 = new kullanilanIlaclar();
            kullanilan1.kayitNo = 0;
            kullanilan1.hastaNo = hasta1;   // hasta1 atanıyor
            kullanilan1.ilacno = i1;        // i1 atanıyor

            kullanilanIlaclar kullanilan2 = new kullanilanIlaclar();
            kullanilan2.kayitNo = 1;
            kullanilan2.hastaNo = hasta2;   // hasta2 atanıyor
            kullanilan2.ilacno = i2;        // i2 atanıyor

            kullanilanIlaclar kullanilan3 = new kullanilanIlaclar();
            kullanilan3.kayitNo = 2;
            kullanilan3.hastaNo = hasta3;   // hasta3 atanıyor
            kullanilan3.ilacno = i1;        // i1 atanıyor

            kullanilanIlaclar kullanilan4 = new kullanilanIlaclar();
            kullanilan4.kayitNo = 3;
            kullanilan4.hastaNo = hasta4;   // hasta4 atanıyor
            kullanilan4.ilacno = i2;        // i2 atanıyor

            // Kayıtların yazdırılması
            Console.WriteLine("Kayit1");
            Console.WriteLine($"Kayit Idı={kayit1.kayit}");
            Console.WriteLine($"Kayit Tarihi={kayit1.kayitT}");
            Console.WriteLine($"Hasta Adı: {kayit1.hasta.hastaAd}");
            Console.WriteLine($"Bolum Adı: {kayit1.bolumu.BolumAD}");
            Console.WriteLine($"Doktor Adı: {kayit1.doktoru.doktorAd}");
            Console.WriteLine($"Hemsire Adı: {kayit1.hemsireler.hemsireAd}");

            Console.WriteLine("\nKayit2");
            Console.WriteLine($"Kayit Idı={kayit2.kayit}");
            Console.WriteLine($"Kayit Tarihi={kayit2.kayitT}");
            Console.WriteLine($"Hasta Adı: {kayit2.hasta.hastaAd}");
            Console.WriteLine($"Bolum Adı: {kayit2.bolumu.BolumAD}");
            Console.WriteLine($"Doktor Adı: {kayit2.doktoru.doktorAd}");
            Console.WriteLine($"Hemsire Adı: {kayit2.hemsireler.hemsireAd}");

            Console.WriteLine("\nKayit3");
            Console.WriteLine($"Kayit Idı={kayit3.kayit}");
            Console.WriteLine($"Kayit Tarihi={kayit3.kayitT}");
            Console.WriteLine($"Hasta Adı: {kayit3.hasta.hastaAd}");
            Console.WriteLine($"Bolum Adı: {kayit3.bolumu.BolumAD}");
            Console.WriteLine($"Doktor Adı: {kayit3.doktoru.doktorAd}");
            Console.WriteLine($"Hemsire Adı: {kayit3.hemsireler.hemsireAd}");
            Console.ReadKey();


        }
        class Bolumler
        {
            public int BolumId { get; set; }
            public string BolumAD { get; set; }
        }
        class Doktorlar
        {
            public int doktorID { get; set; }
            public string  doktorAd { get; set; }
            public Bolumler Bolumu { get; set; }
        }
        class Hemsireler
        {
            public int hemsireID { get; set; }
            public string hemsireAd { get; set; }
            public Bolumler Bolumu { get; set; }

        }
        class Stajyerler
        {
            public int stajyerID { get; set; }
            public string stajyerAd { get; set; }
            public Bolumler Bolumu { get; set; }

        }
        class Ogrenciler
        {
            public int ogrenciID { get; set; }
            public string ogrenciAd { get; set; }
            public Bolumler Bolumu { get; set; }

        }
        class Calisanlar
        {
            public int stajyerID { get; set; }
            public string stajyerAd { get; set; }
            public Bolumler Bolumu { get; set; }
        }
        class Hastalar
        {
            public int hastaID { get; set; }
            public string hastaAd { get; set; }
            
        }
        class hastaKayit
        {
            public int kayit { get; set; }
            public Hastalar hasta { get; set; }
            public Bolumler bolumu { get; set; }
            public Doktorlar doktoru { get; set; }
            public Hemsireler hemsireler { get; set; }
            
            public DateTime kayitT { get; set; }
        }
            
        class ilaclar
        {
            public int ilacID { get; set; }
            public string ilacAd { get; set; }
        }
        class kullanilanIlaclar
        {
            public int kayitNo { get; set; }
            public Hastalar hastaNo { get;set; }
            public ilaclar ilacno { get; set; }
        }
    }
}
