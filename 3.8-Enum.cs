using System;
using System.Collections;

namespace console_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.pazar);   
            Console.WriteLine((int)Gunler.cumartesi);   
            Console.WriteLine((int)Gunler.pazar);   

            int sıcaklık = 32;

            if (sıcaklık <= (int)hava.normal)
            {
                Console.WriteLine("hava soguk!");
            }
            else if (sıcaklık >= (int)hava.sıcak)
            {
                Console.WriteLine("sıcak bir gün");
            }
            else if(sıcaklık >=(int)hava.normal && sıcaklık < (int)hava.coksıcak)
                Console.WriteLine("dısarı cıkalım!");

            Console.ReadKey();
        }
    }
    enum Gunler
    {
        pazartesi=1,
        salı,
        carsamba,
        persembe,
        cuma=32,
        cumartesi,
        pazar
    }

    enum hava
    {
        soguk = 10,

        normal = 20,

        sıcak = 30,

        coksıcak = 40,
    }
}
