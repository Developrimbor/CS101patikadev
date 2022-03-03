using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***** DateTime *****");

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            
            Console.WriteLine(DateTime.Now.ToLongDateString);
            Console.WriteLine(DateTime.Now.ToShortDateString);
            Console.WriteLine(DateTime.Now.ToLongTimeString);
            Console.WriteLine(DateTime.Now.ToShortTimeString);

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            Console.WriteLine(DateTime.Now.ToString("dd")); // 24
            Console.WriteLine(DateTime.Now.ToString("ddd")); // sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); // saturday
           
            Console.WriteLine(DateTime.Now.ToString("MM")); // 04
            Console.WriteLine(DateTime.Now.ToString("MM")); // Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // April
            
            Console.WriteLine(DateTime.Now.ToString("yy")); // 21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2021

            Console.WriteLine("***** Math *****");

            Console.WriteLine(Math.Abs(-25)); // 25 (mutlak degerini alır!)
            Console.WriteLine(Math.Sin(20));
            Console.WriteLine(Math.Cos(20));
            Console.WriteLine(Math.Tan(20));

            Console.WriteLine(Math.Ceiling(10.3)); // 11 (her zaman bir üst sayıya yuvarlar)
            Console.WriteLine(Math.Round(10.3)); // 10 (en yakın tam sayıya yuvarlar)
            Console.WriteLine(Math.Round(10.7)); // 11 
            Console.WriteLine(Math.Round(10.5)); // 10
            Console.WriteLine(Math.Floor(10.7)); // 10 (her zaman küçük olana yuvarlar!)

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4)); // 3^4
            Console.WriteLine(Math.Sqrt(3)); // karekök 3
            Console.WriteLine(Math.Log(9)); // 9'un e tabanındaki logarıtmık karsılıgını verir! 
            Console.WriteLine(Math.Exp(3)); // e^3
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanndaki karsılıgı!


            Console.ReadKey();
        }
    }
}
