using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class Program
    {
        public static Board board1 { get; set; }
        public static KullanıcıList user1 { get; set; }

        static void Main(string[] args)
        {
            board1 = new Board();
            user1 = new KullanıcıList();

            while (true)
            {
                Anasayfa();
            }
        }

        public static void Anasayfa()
        {
            int seçim;
            
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            
            seçim = Int32.Parse(Console.ReadLine());

            switch (seçim)
            {
                case 1:
                    boardList();
                    break;
                case 2:
                    yeniKart();
                    break;
                case 3:
                    kartSil();
                    break;
                case 4:
                    kartTası();
                    break;
                default:
                    Console.WriteLine("!!! HATA !!!");
                    break;
            }
        }

        private static void kartTası()
        {
            string baslıK, _line = String.Empty;
            Card _card = new Card(null, null, -1, -1); 
            int index = -1;
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            baslıK = Console.ReadLine();

            int todo, inProgress, done;
            todo = board1.TODO.FindIndex(x => x.Baslık.ToLower() == baslıK.ToLower());
            inProgress = board1.IN_PROGRESS.FindIndex(x => x.Baslık.ToLower() == baslıK.ToLower());
            done = board1.DONE.FindIndex(x => x.Baslık.ToLower() == baslıK.ToLower());

            if (todo >= 0)
            {
                _line = "TODO";
                index = todo;
            }
            else if (inProgress >= 0)
            {
                _line = "IN_PROGRESS";
                index = inProgress;
            }
            else if (done >= 0)
            {
                _line = "DONE";
                index = done;
            }
            else
            {
                Console.WriteLine("Kart Bulunamadı! Lütfen bir seçim yapın:");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                
                int _seçim = Int32.Parse(Console.ReadLine());

                if (_seçim == 1)
                    Anasayfa();
               
                else if (_seçim == 2)
                    kartTası();
               
                else
                {
                    Console.WriteLine("!!! HATA !!!");
                    Anasayfa();
                }
            }

            if (_line is not null)
            {
                _card = board1.GetProperty(_line).Find(x => x.Baslık.ToLower() == baslıK.ToLower());

                Console.WriteLine();
                Console.WriteLine("Başlık      : {0}", _card.Baslık);
                Console.WriteLine("İçerik      : {0}", _card.Icerik);
                Console.WriteLine("Atanan Kişi : {0}", user1.all.Find(x => x.Id == _card.kisiBilgi).FullName);
                Console.WriteLine("Büyüklük    : {0}", ((SizeEnum)_card.Size).ToString());
                Console.WriteLine("Line        : {0}", _line);

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçin:");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                int _seçim1 = Int32.Parse(Console.ReadLine());

                if (_seçim1 == 1)
                {
                    board1.GetProperty(_line).RemoveAt(index);
                    board1.TODO.Add(_card);
                }
                else if (_seçim1 == 2)
                {
                    board1.GetProperty(_line).RemoveAt(index);
                    board1.IN_PROGRESS.Add(_card);
                }
                else if (_seçim1 == 3)
                {
                    board1.GetProperty(_line).RemoveAt(index);
                    board1.DONE.Add(_card);
                }
                else
                {
                    Console.WriteLine("!!! HATA !!!");
                    Anasayfa();
                }
                boardList();
            }
        }

        private static void kartSil()
        {
            string baslıK;
            Console.WriteLine("Silmek istediğiniz kartı seçiniz!");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            baslıK = Console.ReadLine();

            int todo, inProgress, done;
            todo = board1.TODO.FindIndex(x => x.Baslık.ToLower() == baslıK.ToLower());
            inProgress = board1.IN_PROGRESS.FindIndex(x => x.Baslık.ToLower() == baslıK.ToLower());
            done = board1.DONE.FindIndex(x => x.Baslık.ToLower() == baslıK.ToLower());

            if (todo >= 0)
                board1.TODO.RemoveAt(todo);
            else if (inProgress >= 0)
                board1.IN_PROGRESS.RemoveAt(inProgress);
            else if (done >= 0)
                board1.DONE.RemoveAt(done);
            else
            {
                Console.WriteLine("Kart bulunamadı!");
                Anasayfa();
            }
            Console.WriteLine("işlem başarılı!");
        }

        private static void yeniKart()
        {
            string baslıK, _content;
            int _size;
            int kisiB;

            Console.WriteLine("Başlık Giriniz :");
            baslıK = Console.ReadLine();

            Console.WriteLine("İçerik Giriniz :");
            _content = Console.ReadLine();

            Console.WriteLine("Büyüklük ==> XS(1),S(2),M(3),L(4),XL(5) :");
            _size = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Kişi Seçiniz (1-5 arası bir rakam)              :");
            kisiB = Int32.Parse(Console.ReadLine());

            board1.TODO.Add(new Card(baslıK, _content, kisiB, _size));
        }

        public static void boardList()
        {

            Console.WriteLine("TODO Line");
            Console.WriteLine("--------------------");

            if (board1.TODO.Count > 0)
                printLine(board1.TODO, user1);
            else
                Console.WriteLine("!");
            //
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("--------------------");

            if (board1.IN_PROGRESS.Count > 0)
                printLine(board1.IN_PROGRESS, user1);
            else
                Console.WriteLine("!");
            //
            Console.WriteLine("DONE Line");
            Console.WriteLine("--------------------");
            if (board1.DONE.Count > 0)
                printLine(board1.DONE, user1);
            else
                Console.WriteLine("!");
        }
        // kolonları yazdıracak fonksiyon
        public static void printLine(List<Card> col, KullanıcıList users)
        {
            foreach (var item in col)
            {
                Console.WriteLine("Başlık      : {0}", item.Baslık);
                Console.WriteLine("İçerik      : {0}", item.Icerik);
                Console.WriteLine("Atanan Kişi : {0}", users.all.Find(x => x.Id == item.kisiBilgi).FullName);
                Console.WriteLine("Büyüklük    : {0}", ((SizeEnum)item.Size).ToString());
                Console.WriteLine("-");
            }
        }
    }

}