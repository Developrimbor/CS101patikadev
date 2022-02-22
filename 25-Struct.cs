using System;
using System.Collections;

namespace console_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            dikdortgen dikdortgen = new dikdortgen();
            dikdortgen.kisakenar = 3;    
            dikdortgen.uzunkenar = 4;    

            Console.WriteLine("class alan hesabı : {0}", dikdortgen.AlanHesapla());

            dikdortgen_struct dikdortgen_Struct = new dikdortgen_struct();
            dikdortgen_Struct.kisakenar = 3;
            dikdortgen_Struct.uzunkenar = 4;

            Console.WriteLine("class alan hesabı : {0}", dikdortgen_Struct.AlanHesapla());


            Console.ReadKey();
        }
    }
    class dikdortgen
    {
        public int kisakenar;
        public int uzunkenar;
        public long AlanHesapla()
        {
            return this.kisakenar * this.uzunkenar;
        }
    }

    struct dikdortgen_struct
    {
        public int kisakenar;
        public int uzunkenar;
        public long AlanHesapla()
        {
            return this.kisakenar * this.uzunkenar;
        }
    }
}
