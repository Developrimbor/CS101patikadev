namespace ToDoApp
{
    public class Card
    {
        public string Baslık { get; set; }
        public string Icerik { get; set; }
        public int kisiBilgi { get; set; }
        public int Size { get; set; }
        public Card(string baslık, string icerik, int userId, int size)
        {
            Baslık = baslık;
            Icerik = icerik;
            kisiBilgi = userId;
            Size = size;
        }
    }

}