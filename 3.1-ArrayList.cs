using System;
using System.Collections;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add("Ayşe");
            list.Add(21);
            list.Add(true);
            list.Add('A');

            Console.WriteLine(list[1]);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Add Range *****");
            string[] renkler = {"kırmızı", "sarı", "yesil"};
            List<int> sayılar = new List<int>(){1,5,2,9,6};
            list.AddRange(renkler);
            list.AddRange(sayılar);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Sort *****");
            list.Sort();

            foreach (var item in list)
            {
                Console.Write(item);
            }

            Console.WriteLine("***** Binary Search *****");

            Console.WriteLine(list.BinarySearch(9));

            Console.WriteLine("***** Reverse *****");

            list.Reverse();

            Console.WriteLine("***** Clear *****");

            list.Clear();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
