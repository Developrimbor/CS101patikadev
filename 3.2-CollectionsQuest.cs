using System;
using System.Collections;

namespace Odev2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.WriteLine("***Koleksiyonlar 1. SORU***");
        Console.WriteLine();
        Console.WriteLine("Lütfen 20 adet pozitif sayı giriniz!");

        ArrayList asalSayilar = new ArrayList();
        ArrayList asalDegil = new ArrayList();
        
        int sayi;
        bool control = false;


        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("{0}. sayıyı giriniz", (i + 1));

            int.TryParse(Console.ReadLine(), out sayi);
        
            if (sayi > 0)
            {
                for (int j = 2; j < sayi/2; j++)
                {
                    if (sayi%j == 0)
                    {
                        control = true;
                    }
                }
            }
        
        if (control == true)
        {
            if (sayi == 2)
            {
                asalSayilar.Add(sayi);
            }
            else
            {
                asalDegil.Add(sayi);
            }
        }
        else
        {
            if (sayi == 1)
            {
                asalDegil.Add(sayi);
            }
            else
            {
                asalSayilar.Add(sayi);
            }
        }

        control = false;
        }
        Console.WriteLine();
        Console.WriteLine();
        asalSayilar.Sort();
        asalDegil.Sort();
        Console.WriteLine("Asal Sayılar : ");

        foreach (int i in asalSayilar)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Asal Olmayan Sayılar : ");

        foreach (int i in asalDegil)
        {   
            Console.WriteLine(i);
        }

        Console.WriteLine();
        Console.WriteLine();
        
        int asalElemanS = asalSayilar.Count;
        double asalElemanST = 0;

        foreach (int i in asalSayilar)
        {
            asalElemanST += i;
        }

        var asalOrt = asalElemanST/asalElemanS;

        Console.WriteLine("Asal olanların eleman sayısı : {0} ortalaması : {1}", asalElemanS.ToString(),Math.Round(asalOrt,2).ToString());
        Console.WriteLine();
        Console.WriteLine();

        int asalOlmayanElemanS = asalDegil.Count;
        double asalOlmayanElemanST = asalDegil.Count;

        foreach (int i in asalDegil)
        {
            asalOlmayanElemanST += i;
        }
        
        var asalOlmayanOrt = asalOlmayanElemanST/asalOlmayanElemanS;
        Console.WriteLine("Asal olmayanların eleman sayısı: {0} ortalaması: {1}", asalOlmayanElemanS.ToString(), Math.Round(asalOlmayanOrt,2).ToString());
        Console.WriteLine();

        Console.WriteLine("***Koleksiyonlar 2.SORU***");
        Console.WriteLine();
        Console.WriteLine("Lütfen 20 adet sayı giriniz!");
        Console.WriteLine();

        int[] sayıDizisi = new int[20];

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("lütfen {0}. sayıyı giriniz : ", i +1);
            sayıDizisi[i] = int.Parse(Console.ReadLine());
        } 

        int[] minDeger = new int[3];
        int[] maxDeger = new int[3];

        Array.Sort(sayıDizisi);

        double minDegerOrt = 0;

        for (int i = 0; i < 3; i++)
        {
            minDeger[i] = sayıDizisi[i];
        }

        Console.WriteLine("dizinin en küçük 3 elemanı : ");

        foreach (var item in minDeger)
        {
            Console.WriteLine(item);
            minDegerOrt += item;
        }

        double maxDegerOrt = 0;

        Array.Reverse(sayıDizisi);

        for (int i = 0; i < 3; i++)
        {
            maxDeger[i] = sayıDizisi[i];
        }

        Console.WriteLine("dizinin en büyük 3 elemanı : ");

        foreach (var item in maxDeger)
        {
            Console.WriteLine(item);
            maxDegerOrt += item;
        }

        Console.WriteLine("Küçükler Dizisinin Ortalaması: " + minDegerOrt/3);
        Console.WriteLine("Byükler Dizisinin Ortalaması: " + maxDegerOrt/3);
        Console.WriteLine("Küçükler Dizisinin Ortalama Toplamları: " + minDegerOrt);
        Console.WriteLine("Büyükler Dizisinin Ortalama Toplamları: " + maxDegerOrt);
        Console.WriteLine();

        Console.WriteLine("***Koleksiyonlar 3.SORU***");
        Console.WriteLine();

        List<char> sesliler = new List<char>();
        string sesliChar = "aeıioöuü";

        Console.WriteLine("Lütfen bir kelime giriniz : ");
        string metin = Console.ReadLine().ToLower();

        for (int i = 0; i < metin.Length; i++)
        {
            if (sesliChar.Contains(metin[i]))
            {
                sesliler.Add(metin[i]);
            }
        }

        if (sesliler.Count > 0)
        {
            foreach (var item in sesliler)
            {
                Console.WriteLine(item);
            }
        }

        else
        {
            Console.WriteLine("Sesli harf bulunamamaktadır!");
        }

        Console.ReadKey();
        }

    }


}
