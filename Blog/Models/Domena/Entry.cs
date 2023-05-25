namespace Blog.Models.Domena
{
    public class Entry
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        
        //do komentarzy
        public ICollection<Komentarz> KomentarzeWpisu { get; set; }


    }
}
