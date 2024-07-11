using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._06._2024_ders2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if for ornekleri 
            //orn1();
            //orn1chat();
            //orn2();
            //orn3for();
            //orn4();
            //orn5();
            //orn6();
            //orn7();
            //orn8();
            //orn9();
            //orn10();
            //orn11();



            Console.ReadKey();

        }

        private static void orn11()
        {
            //kullanının girdigi bir kelimeyi tersten yazan programı yazınız
            string kelime;
            Console.WriteLine("kelime gir");
            kelime = Console.ReadLine();
            //abc girerse cba gormeliyim

            // Console.WriteLine(kelime[2]); 2.indexi yaz

            for (int i = kelime.Length - 1; i > -1s; i--)
            {
                Console.Write(kelime[i]);
            }
        }

        private static void orn10()
        {

            //kullanıcının girdigi 10 sayıdan tekleri ayrı çiftleri ayrı toplayan ve toplamları ekrana yazdıran program
            int sayi, tToplam, cToplam;
            cToplam = 0;
            tToplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0}.Sayiyi Giriniz..:", i);
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    cToplam += sayi;
                }
                else if (sayi % 2 == 1)
                {
                    tToplam += sayi;                    
                }
                

            }
            Console.WriteLine("Çift Sayiların toplamı.: {0} \nTek Sayilarin Toplami.: {1}", cToplam, tToplam);
            
        }

        private static void orn9()
        {
            //kullanıcının girdigi bir sayının asal olup olmadıgını bulan programı giriniz
            int sayi;
            Console.WriteLine("Sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            //bool asal = true;
            int durum = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    durum = 1;
                    //asal = false;                    
                }
            }


            if (durum ==0)
            {
                Console.WriteLine("Asal");
            }
            else
            {
                Console.WriteLine("Asal değil");
            }
        }

        private static void orn8()
        {
            //döngü kullanarak aşağıdaki şekli olusturunuz
            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            //********
            //*********

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= i; j++) //neden i ye kadar iç içe dongu carpımdır

                {
                    Console.Write("*");
                }
                Console.WriteLine(); //yazdıktan sonra 1 alta in
            }
        }

        private static void orn7()
        {
            //kullanıcının girdigi 2 sayı arasındaki çift sayıları yazdıran program
            int s1, s2;
            Console.WriteLine("1.Sayiyi Giriniz");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayiyi Giriniz");
            s2 = Convert.ToInt32(Console.ReadLine());

            if (s1 > s2)
            {
                for (int i = s2+1; i < s1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            else if (s2 > s1)
            {
                for (int i = s1+1; i < s2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else Console.Write("Aynı Sayı degerleri girdiniz");
        }

        private static void orn6()
        {
            //kullanıcının girdigi 2 sayı arasındaki tek sayıları yazdıran program
            int s1, s2;
            Console.WriteLine("1.Sayiyi Giriniz");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayiyi Giriniz");
            s2 = Convert.ToInt32(Console.ReadLine());
            

            if (s1 > s2)
            {
                for (int i = s2+1; i < s1; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                       
                    }
                }

            }
            else if (s2 > s1)
            {
                for (int i = s1+1; i < s2; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else Console.Write("Aynı Sayı degerleri girdiniz");
        }

        private static void orn5()
        {
            //kullanıcının girdigi 2 sayı arasındaki sayıları ekrana yazan programı ekrana yazınız
            int s1, s2;
            Console.WriteLine("1.Sayiyi Giriniz");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayiyi Giriniz");
            s2 = Convert.ToInt32(Console.ReadLine());

            if (s1 > s2)
            {
                for (int i = s2+1; i < s1; i++) //+1 olma sebebi kendini yazdırmamak
                {
                    Console.WriteLine(i);
                }

            }
            else if (s2 > s1)
            {
                for (int i = s1+1; i < s2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else Console.Write("Aynı Sayı degerleri girdiniz");
        }

        private static void orn4()
        {
            //kullanıcının gırdıgı 10 sayının ortalamasını bulan programı yazınız

            int toplam, a, sayi;
            double ort;
            toplam = 0;
            // Console.WriteLine("10 tane sayı giriniz");
            for (int i = 0; i < 10; i++)
            {
                a = i + 1;
                Console.Write("{0}.Sayiyi Gir..:", a);
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
            }
            ort = toplam / 10;
            Console.WriteLine("Girilen Degelerin ortalaması {0} 'dır", ort.ToString());
        }

        private static void orn3for()
        {
            //ekrana 8 kere selam yazan program
            //Console.WriteLine("selam");
            //Console.WriteLine("selam");
            //Console.WriteLine("selam");
            //Console.WriteLine("selam");
            //Console.WriteLine("selam");
            //Console.WriteLine("selam");
            //Console.WriteLine("selam");
            //Console.WriteLine("selam");
            //dongu kullan bunun yerine 

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Selam");
            }
            Console.ReadKey();
        }

        private static void orn1chat()
        {
            int s1, s2, s3, ort;
            int enb, enk;

            Console.WriteLine("Üç sayı giriniz:");
            s1 = Convert.ToInt32(Console.ReadLine());
            s2 = Convert.ToInt32(Console.ReadLine());
            s3 = Convert.ToInt32(Console.ReadLine());

            // Başlangıçta enb ve enk değerlerini girilen ilk sayı olarak atayalım
            enb = s1;
            enk = s1;

            // En büyük ve en küçük değerleri belirleyelim
            if (s2 > enb)
                enb = s2;
            else if (s2 < enk)
                enk = s2;

            if (s3 > enb)
                enb = s3;
            else if (s3 < enk)
                enk = s3;

            // Ortalama hesaplama
            ort = (s1 + s2 + s3) - enb - enk;

            Console.WriteLine("En büyük: " + enb + ", En küçük: " + enk + ", Ortalama: " + ort);
            Console.ReadKey();
        }

        private static void orn2()
        {
            Console.Write("Metin Giriniz..:");
            string metin = Console.ReadLine();            

            int harfS;
            harfS = metin.Count(); //karekter sayma
            Console.WriteLine("Metin {0} Karakterlidir", harfS);
            Console.ReadKey();
        }

        private static void orn1()
        {
            //kullanıcının girdigi 3 sayidan enb ve enk oln sayıların ort bulan programı yazınız
            int s1, s2, s3, ort;
            int enb, enk;
            
            enb = 0; //eger hic iflere girmezse garanti olması icin default deger verdim
            enk = 0;
            Console.WriteLine("sayi giriniz");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sayi giriniz");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sayi giriniz");
            s3 = Convert.ToInt32(Console.ReadLine());

            if (s1 == s2 && s1 == s3)
            {
                ort = (s1 + s2) / 2;
                Console.WriteLine("Sayilar Esit Ve Ortalamaları");
            }
            //enb s1
            if (s1 > s2 && s1 > s3)
            {
                if (s2 > s3)
                {
                    enk = s3;
                    enb = s1;
                    ort = (enb + enk) / 2;
                    Console.WriteLine("eNB..:" + enb + "enk..:" + enk + "ort..:" + ort);
                }
                else if (s3 > s2)
                {
                    enk = s2;
                    enb = s1;
                    ort = (enb + enk) / 2;
                    Console.WriteLine("eNB..:" + enb + "enk..:" + enk + "ort..:" + ort);
                }
                else
                {
                    enb = s1;
                    enk = s2;
                    ort = (enb + enk) / 2;
                    Console.WriteLine("eNB..:" + enb + "enk..:" + enk + "ort..:" + ort);
                }              

            }
            //enb 2
            if (s2 > s1 && s2 > s3)
            {
                if (s1 > s3)
                {
                    enk = s3;
                    enb = s2;
                    ort = (enb + enk) / 2;
                    Console.WriteLine("eNB..:" + enb + "enk..:" + enk + "ort..:" + ort);
                }
                else if (s3 > s1)
                {
                    enk = s1;
                    enb = s2;
                    ort = (enb + enk) / 2;
                    Console.WriteLine("eNB..:" + enb + "enk..:" + enk + "ort..:" + ort);
                }
                else
                {
                    enb = s2;
                    enk = s1;
                    ort = (enb + enk) / 2;
                    Console.WriteLine("eNB..:" + enb + "enk..:" + enk + "ort..:" + ort);
                }               

            }
            //enb3
            if (s3 > s1 && s3 > s2)
            {
                if (s2 > s1)
                {
                    enk = s1;
                    enb = s3;
                    ort = (enb + enk) / 2;
                    Console.WriteLine("eNB..:" + enb + "enk..:" + enk + "ort..:" + ort);
                }
                else if (s1 > s2)
                {
                    enk = s2;
                    enb = s3;
                    ort = (enb + enk) / 2;
                    Console.WriteLine("eNB..:" + enb + "enk..:" + enk + "ort..:" + ort);
                }
                else
                {
                    enb = s3;
                    enk = s1;
                    ort = (enb + enk) / 2;
                    Console.WriteLine("eNB..:" + enb + "enk..:" + enk + "ort..:" + ort);
                }
                
                // benım yazdıgım program 2 tane enb oldugunda calısmaz

            }

            Console.ReadKey();
        }
    }
}
