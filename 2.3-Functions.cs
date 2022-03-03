using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            Console.WriteLine(a+b); 

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            metotlar ornek = new metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc)); // public ile erişim saglamalıyız! 
                                       // EkranaYazdir string türünde oldugundan sonuc'u string cevirmemiz gerekir!

            int sonuc2 = ornek.ArttırVeTopla(a, b); 
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a + b)); // a ve b yi ref olarak belirlersek sonuc 7 olur! global olarak a ve b yi degistirdik!

            Console.ReadKey();
        }

        static int Topla(int deger1, int deger2) // erisimi satatic ile sagladik!
        {
            return(deger1+ deger2);
        }

    }

    class metotlar
    {
        public void EkranaYazdir(string veri) // public ile erisim sagladık!
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(int deger1, int deger2) // ref int seklinde tanımlanmalıdır!
        {
            deger1 += 1;
            deger2 += 1;

            return deger1+ deger2;
        }
    }
}
