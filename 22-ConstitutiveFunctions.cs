using System;
using System.Collections;

namespace console_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            calisan calisan1 = new calisan("yusuf","gulmez",55500077,"BSM");
            //calisan1.ad = "Yusuf";
            //calisan1.soyad ="Gulmez";
            //calisan1.no = 55500077;
            //calisan1.departman = "BSM";

            calisan1.CalisanBilgileri();

            Console.ReadKey();
        }
    
    }

    class calisan
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;

        public calisan(string ad, string soyad, int no, string departman)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.no = no;
            this.departman = departman;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("calısanın adı : {0}", ad);
            Console.WriteLine("calısanın soyadı : {0}", soyad);
            Console.WriteLine("calısanın numarası : {0}", no);
            Console.WriteLine("calısanın departmanı : {0}", departman);
        }
    }
}
