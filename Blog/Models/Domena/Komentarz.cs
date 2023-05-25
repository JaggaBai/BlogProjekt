namespace Blog.Models.Domena
{
    public class Komentarz
    {
        public Guid Id { get; set; }
        public string Opinia { get; set; }
        public Guid EntryId { get; set; }
    }
}
