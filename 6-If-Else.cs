using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int time = DateTime.Now.Hour;

            if(time >= 6 && time <= 12)
                Console.WriteLine("gunaydin!");

            else if(time <= 18)
                Console.WriteLine("iyi gunler!");
            
            else
                Console.WriteLine("iyi geceler!");

            Console.ReadKey();
        }
    }
}
