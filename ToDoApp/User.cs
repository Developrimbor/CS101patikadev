namespace ToDoApp
{
    public class Kullanıcı
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public Kullanıcı(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }
    }
}
