using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            int result = 1;
           
            for (int i = 0; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);
            
            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metotlar

            string ifade = "Yusuf Gülmez";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());

            Console.ReadKey();
        }
    }
    
    public class Islemler
    {

        public int Expo(int sayi, int üs)
        {
            if(üs<2)
                return sayi;
            
            return Expo(sayi, üs-1)*sayi;
        }
        // Expo(3,4)
        // Expo(3,3) 3
        // Expo(3,2) 3 * 3
        // Expo(3,1) 3 * 3 *3
        // 3 * 3 * 3 * 3 = 3^4

    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
    
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
    }
}
