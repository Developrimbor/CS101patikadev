using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            Console.WriteLine("isminizi giriniz : ");
            string name = Console.ReadLine();
            Console.WriteLine("soyadınızı giriniz : ");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);

            Console.ReadKey();
        }
    }
}
