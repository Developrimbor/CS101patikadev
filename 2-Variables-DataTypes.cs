using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            int deger = 2;

            string degisken = null;
            string Degisken = null;

            string t1est;

            byte b = 5; // 1 byte
            sbyte c = 5; // 1 byte
            short s = 5; // 2 byte
            ushort us = 5; // 2 byte
            int i = 2; // 4 byte 
            uint ui = 2; // 4 byte
            long l = 4; // 8 byte
            ulong ul = 4; // 8 byte
            float f = 5; // 4 byte
            double d = 5; // 8 byte
            decimal de = 5; // 16 byte
            char ch = '2'; // 2byte
            string str = "yusuf"; // sınırsız
            bool b1 = true;
            bool b2 = false;
            
            DateTime dt = DateTime.Now;

            Int16 i16 = 2; // 2 byte
            Int32 i32 = 2; // 4 byte
            Int64 i64 = 2; // 8 byte

            Console.WriteLine(dt);

            object o1 = 'x';
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            string str1 = string.Empty;
            str1 = "yusuf";

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString(); // int degeri stringe donusturme

            Console.WriteLine(yeniDeger); // 2020

            int int21 = int20 + Convert.ToInt32(str20); // string degeri int degere donusturme
            
            Console.WriteLine(int21); // 40

            int int22 = int20 + int.Parse(str20); // 40 (stringi inte donusturur)

            Console.ReadKey();
        }
    }
}
