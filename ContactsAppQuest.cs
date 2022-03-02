using System;
using System.Collections.Generic;

namespace TelefonRehberUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            KişiYöneticisi kişiYönet = new KişiYöneticisi();
            Ekran ekran = new Ekran();
            ekran.ekran1();

            String Giris = Console.ReadLine();
            while (true)
            {
                if (Giris == "1")
                {
                    kişiYönet.kişiEkle();
                    break;
                }
                else if (Giris == "2")
                {
                    kişiYönet.kişiSil();
                    break;
                }
                else if (Giris == "3")
                {
                    kişiYönet.kişiGüncelle();
                    break;
                }
                else if (Giris == "4")
                {
                    kişiYönet.rehberArama();
                    break;
                }
                else if (Giris == "5")
                {
                    kişiYönet.kişiArama();
                    break;
                }
                else
                {
                    Console.WriteLine("!!! HATA !!!");
                    Console.ReadLine();
                    break;
                }
            }
            Console.ReadKey();
        }
    }

    public class Kişi
    {
        public string Isim;
        public string SoyIsim;
        public int Telefon;

        public Kişi(string Isim, string SoyIsim, int Telefon)
        {
            this.Isim = Isim;
            this.SoyIsim = SoyIsim;
            this.Telefon = Telefon;
        }
    }
    public class Ekran
    {
        public void ekran1()
        {
            Console.WriteLine("1-Yeni Numara Ekle");
            Console.WriteLine("2-Varolan Numarayı Sil");
            Console.WriteLine("3-Varolan Numarayı Güncelle");
            Console.WriteLine("4-Rehberi Listele");
            Console.WriteLine("5-Rehberde Arama Yap");
        }
    }
    public class Kişiler
    {
        public List<Kişi> kişi = new List<Kişi>();
        public void kişiler()
        {
            kişi.Add(new Kişi("Yusuf", "GÜLMEZ", 506000000));
            kişi.Add(new Kişi("Ömer", "KAÇMAZ", 506000001));
            kişi.Add(new Kişi("Fahri", "COŞKUN", 506000002));
            kişi.Add(new Kişi("İkbal", "YAKUPOĞLU", 506000002));
            kişi.Add(new Kişi("Ozzy", "YAVAŞ", 506000003));
        }
    }
    public class KişiYöneticisi : Kişiler
    {
        public void kişiEkle()
        {
            Console.WriteLine("İsim:");
            string Isim = Console.ReadLine();
            
            Console.WriteLine("Soyad:");
            string SoyIsim = Console.ReadLine();
            
            Console.WriteLine("Telefon:");
            int Telefon = Convert.ToInt32(Console.ReadLine());
            
            Kişi kişi = new Kişi(Isim, SoyIsim, Telefon);

            Console.WriteLine("{0} HOŞGELDİN!", kişi.Isim.ToUpper());
            
            Console.ReadLine();
        }

        public void kişiSil()
        {
            kişiler();
            
            Console.WriteLine("Lütfen silmek istediğiniz kişinin ismini veya soyadını yazınız:");
            
            var arama = Console.ReadLine();
            bool kayıtlıMı = false;
            
            for (var i = 0; i < kişi.Count; i++)
            {
                if (arama == kişi[i].Isim || arama == kişi[i].SoyIsim)
                {
                    
                    Console.WriteLine("Kullanıcı {0} silmek istediğinize emin misiniz e/h", kişi[i].Telefon);
                   
                    var girilen = Console.ReadLine();
                    kayıtlıMı = true;

                    if (girilen == "e")
                    {
                        Console.WriteLine("Silme Başaralı");
                    }
                }
            }
            if (!kayıtlıMı)
            {
                Console.WriteLine("Böyle bir kullanıcı bulamadık");
            }
            Console.ReadLine();
        }
        public void kişiGüncelle()
        {
            kişiler();
            
            Console.WriteLine("Lütfen güncellemek istediğiniz kişinin ismini veya soyadını yazınız:");
            
            var arama = Console.ReadLine();
            bool kayıtlıMı = false;
            
            for (var i = 0; i < kişi.Count; i++)
            {
                if (arama == kişi[i].Isim || arama == kişi[i].SoyIsim)
                {
                    Console.WriteLine("Adı:{0}" +
                    "\nSoyadı:{1}" +
                    "\nNumarası:{2}" +
                    "\n**************", kişi[i].Isim, kişi[i].SoyIsim, kişi[i].Telefon);
                }
            }
            if (!kayıtlıMı)
            {
                Console.WriteLine("Böyle bir kullanıcı bulamadık");
            }
            Console.ReadLine();
        }

        public void rehberArama()
        {
            kişiler();
            for (var i = 0; i < kişi.Count; i++)
            {
                Console.WriteLine("Adı:{0}" +
                "\nSoyadı:{1}" +
                "\nNumarası:{2}" +
                "\n**************", kişi[i].Isim, kişi[i].SoyIsim, kişi[i].Telefon);
            }

            Console.ReadLine();

        }

        public void kişiArama()
        {
            kişiler();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz" +
                "\n**************************************" +
                "\nİsim ve Soyadına göre arama yapmak için (1)" +
                "\nNumaraya göre arama yapmak için (2)");
            var arama = Console.ReadLine();
            if (arama == "1")
            {
                Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin adını veya soyadını yazınız");
                var girilen = Console.ReadLine();
                bool kayıtlıMı = false;
                for (var i = 0; i < kişi.Count; i++)
                {
                    if (girilen == kişi[i].Isim || girilen == kişi[i].SoyIsim)
                    {
                        Console.WriteLine("Adı:{0}" +
                        "\nSoyadı:{1}" +
                        "\nNumarası:{2}" +
                        "\n**************", kişi[i].Isim, kişi[i].SoyIsim, kişi[i].Telefon);
                        kayıtlıMı = true;
                    }
                }
                if (!kayıtlıMı)
                {
                    Console.WriteLine("böyle bir kişi yok!");
                }
            }
            else if (arama == "2")
            {
                Console.WriteLine("Lütfen numarayı tuşlayınız");
                var girilen = Convert.ToInt32(Console.ReadLine());
                bool kayıtlıMı = false;
                for (var i = 0; i < kişi.Count; i++)
                {
                    if (girilen == kişi[i].Telefon)
                    {
                        Console.WriteLine("Adı:{0}" +
                        "\nSoyadı:{1}" +
                        "\nNumarası:{2}" +
                        "\n**************", kişi[i].Isim, kişi[i].SoyIsim, kişi[i].Telefon);
                        kayıtlıMı = true;
                    }
                }
                if (!kayıtlıMı)
                {
                    Console.WriteLine("böyle bir kişi yok!");
                }
            }
            else
            {
                Console.WriteLine("!!! HATA !!!");
            }
            Console.ReadLine();
        }

    }
}
