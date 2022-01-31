using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                
                case 1: 
                    Console.WriteLine("Ocak");
                        break;
                        
                case 2: 
                    Console.WriteLine("Subat");
                        break;
               
                case 3: 
                    Console.WriteLine("Mart");
                        break;
                
                case 4: 
                    Console.WriteLine("Nisan");
                        break;

                default:
                    Console.WriteLine("hata!");
                        break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış!");
                        break;
                
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar");
                        break;
                
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz");
                        break;
                
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("sonbahar");
                        break;
                
                default:
                    break;
            }   

            Console.ReadKey();
        }
    }
}
