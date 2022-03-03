using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);

            if(sonuc)
            {
                Console.WriteLine(outSayi);
                Console.WriteLine("basarili!");
            }
            else
            {
                Console.WriteLine("basarisiz!");
            }

            metotlar instance = new metotlar();
            instance.Topla(2,3, out int toplamSonucu); 
            Console.WriteLine(toplamSonucu);

            // Metot Asırı Yükleme

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("a","b");

            // Metot İmzası
            // metotAdı + parametre sayısı +parametre

            Console.ReadKey();
        }
    }

    class metotlar
    {
        public void Topla(int a, int b, out int Toplam)
        {
            Toplam = a + b;
        }

        public void EkranaYazdir(string veri) // hem string 
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri) // hem de int tipinde parametre turunde karsılıgı oldugu ıcın asırı yukleme oldu!
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
