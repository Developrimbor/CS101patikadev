using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            try // hataya neden olabilen kısım!
            {
           
            Console.WriteLine("bir sayi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("girmiş oldugunuz sayi : " + sayi);

            }
            
            catch (Exception ex) // hatayı yakalar!
            {
            
            Console.WriteLine("hata!:" + ex.Message.ToString()); // hatanın nedeni Message ile ekrana yazilir!
              
            }
            
            finally // her zaman calısır! (optional)
            {

            Console.WriteLine("Islem Tamamlanadı!");

            }

            Console.WriteLine("----------------------------------");
            
            try
            {
               // int a = int.Parse(null);
               // int b = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("bos deger girdiniz!");
                Console.WriteLine(ex);
            }

            catch(FormatException ex1)
            {
                Console.WriteLine("veri tipi uygun degil!");
                Console.WriteLine(ex1);
            }

            catch(OverflowException ex2)
            {
                Console.WriteLine("cok buyuk veya cok kucuk bır deger gırdınız!!");
                Console.WriteLine(ex2);
            }

            Console.ReadKey();
        }
    }
}
