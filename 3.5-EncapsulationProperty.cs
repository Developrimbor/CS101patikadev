using System;
using System.Collections;

namespace console_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci = new ogrenci();
            ogrenci.Isim = "Yusuf";
            ogrenci.Soyisim = "Gulmez";
            ogrenci.OgrenciNo = 201200025;
            ogrenci.Sinif = 1;

            ogrenci.OgrenciBilgileri();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileri();

            Console.ReadKey();
        }
    }
    class ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        {   
            get => sinif; 
            set
            {
                if (value <= 1)
                {
                    Console.WriteLine("sınıf en az 1 olabilir!");
                }
                else
                {
                    sinif = value;
                }
            }
        }

        public ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public ogrenci() {}

        public void OgrenciBilgileri()
        {
            Console.WriteLine("***** öğrenci bilgileri *****");
            Console.WriteLine("öğrenci Adı : {0}", this.Isim);
            Console.WriteLine("öğrenci No : {0}", this.ogrenciNo);
            Console.WriteLine("öğrenci sınıfı : {0}", this.sinif);
        }

        public void SinifAtlat()
        {
            this.sinif = this.sinif +1;
        }
        public void SinifDusur()
        {
            this.sinif = this.sinif -1;
        }

    }
}
