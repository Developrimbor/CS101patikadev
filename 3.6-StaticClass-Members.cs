using System;
using System.Collections;

namespace console_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calısan sayisi : {0}", calisan.CalisanSayisi);
           
            calisan Calisan = new calisan("yusuf","gulmez","BSM");
            Console.WriteLine("calısan sayısı : {0}", calisan.CalisanSayisi);

            Console.WriteLine("Toplama islemi sonucu {0}", Islemler.Topla(100,200));
            Console.WriteLine("Cıkarma islemi sonucu {0}", Islemler.Çıkar(300,200));

            Console.ReadKey();
        }
    }
    class calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static calisan()
        {
            calisanSayisi = 0;
        }

        public calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;
        }
    }

    static class Islemler
    {
        public static long Topla (int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Çıkar (int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }

}
