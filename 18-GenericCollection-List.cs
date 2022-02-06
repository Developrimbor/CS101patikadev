using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            Console.WriteLine(renkListesi.Count); // 5
            Console.WriteLine(sayiListesi.Count); // 6

            // Foreach ve List.ForeEach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);

            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));
                
            // Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            sayiListesi.RemoveAt(0); // 0. indexteki sayıyı listeden çıkarır!
            
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            // Liste içerisinde arama 

            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde bulundu!");
            }

            // Eleman ile index'e erişme

            Console.WriteLine(renkListesi.BinarySearch("Turuncu"));

            // Diziyi List'e çevirme!

            string[] hayvanlar = {"kedi", "köpek"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            // Listeyi Nasıl Temizleriz!

            hayvanListesi.Clear();

            // List içerisinde nesne tutmak!
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıci1 = new Kullanıcılar();
            kullanıci1.Isim = "Yusuf";
            kullanıci1.Soyisim = "Gülmez";
            kullanıci1.Yas = 23;
            
            kullanıcıListesi.Add(kullanıci1);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Yusuf",
                Soyisim = "Gülmez",
                Yas = 23,
            });

            foreach (Kullanıcılar kullanıcı in kullanıcıListesi) // "var" yerine Kullanıcılar'ı kullanabiliriz!
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı:" + kullanıcı.Yas);
            }

            Console.ReadKey();
        }
    }
        public class Kullanıcılar
        {
            private string isim;
            private string soyisim;
            private int yas;

            public string Isim {get => isim; set => isim = value; }
            public string Soyisim {get => soyisim; set => soyisim = value; }
            public int Yas {get => yas; set => yas = value; }
        }
}
