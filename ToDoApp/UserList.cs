
using System.Collections.Generic;

namespace ToDoApp
{
    public class KullanıcıList
    {
        public List<Kullanıcı> all = new List<Kullanıcı>();

        public KullanıcıList()
        {
            all.Add(new Kullanıcı(1, "Yusuf GULMEZ"));
            all.Add(new Kullanıcı(2, "Fahri COSKUN"));
            all.Add(new Kullanıcı(3, "İkbal YAKUPOGLU"));
            all.Add(new Kullanıcı(4, "Omer KACMAZ"));
        }
    }
}