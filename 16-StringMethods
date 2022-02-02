using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hosgeldiniz!";
            string degisken2 = "Hello World!";
            string degisken3 = "dersimiz CSharp, Hosgeldiniz!";
            string degisken4 = "Hello";

            Console.WriteLine(degisken.Length);

            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            Console.WriteLine(String.Concat(degisken, "Merhaba"));

            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken3,true));
            Console.WriteLine(String.Compare(degisken,degisken3,false));

            Console.WriteLine(degisken2.Contains(degisken4)); // degisken2 de degisken4 var mı

            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Hello"));

            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("hello"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            Console.WriteLine(degisken.Insert(0, "Merhaba "));
         
            Console.WriteLine(degisken + degisken2.PadLeft(30)); 
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*')); 
            Console.WriteLine(degisken.PadRight(50) + degisken2); 
            Console.WriteLine(degisken.PadRight(50, '*') + degisken2); 

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            Console.WriteLine(degisken.Split(' ')[1]);

            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

            Console.ReadKey();
        }
    }
}
