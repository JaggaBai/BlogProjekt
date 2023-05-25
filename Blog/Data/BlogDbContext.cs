using Blog.Models.Domena;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Komentarz> Komentarz { get; set; }   
    }
}
