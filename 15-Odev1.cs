using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("****** 1.Soru ******");
            Console.WriteLine("--------------------");
            
            Console.WriteLine("lütfen pozitif bir sayi giriniz");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}.Sayıyı Giriniz;", i+1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Çift "+sayi);
                }
            }
            
            Console.WriteLine("--------------------");
            Console.WriteLine("****** 2.Soru ******");
            Console.WriteLine("--------------------");
            
            Console.WriteLine("Lütfen pozitif iki adet sayı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int[] dizi2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("bir sayi giriniz!");
                dizi2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (b == dizi2[i] || b % dizi2[i] == 0)
                {
                    Console.WriteLine(dizi2[i]);
                }
            }
            
            Console.WriteLine("--------------------");
            Console.WriteLine("****** 3.Soru ******");
            Console.WriteLine("--------------------");
            Console.WriteLine("pozitif bir sayi giriniz!");
           
            int c = Convert.ToInt32(Console.ReadLine());
            string[] dizi3 = new string[c];

            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("bir kelime giriniz!");
                dizi3[i] = Convert.ToString(Console.ReadLine());
            } 

            foreach (var i in dizi3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----");

            Array.Reverse(dizi3);

            foreach (var i in dizi3)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("--------------------");
            Console.WriteLine("****** 4.Soru ******");
            Console.WriteLine("--------------------");
            
            Console.WriteLine("lütfen bir cümle giriniz!");

            string Cumle = Convert.ToString(Console.ReadLine());

            string[] Cumle2 = Cumle.Split(" ");
            char[] harfler = Cumle.ToCharArray();
            int toplamKelime = 0;
            int toplamHarf = 0;

            foreach (var item in Cumle2)
            {
                toplamKelime++;
            }

            foreach (var item in harfler)
            {
                if(item == ' ')
                    continue;

                toplamHarf++;
            }

            Console.WriteLine("Toplam Harf : " + toplamHarf);
            Console.WriteLine("Toplam Kelime : " + toplamKelime);

            Console.ReadKey();
        }
    }
}
