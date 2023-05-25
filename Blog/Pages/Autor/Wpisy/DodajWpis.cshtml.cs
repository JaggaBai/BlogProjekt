using Blog.Data;
using Blog.Models.Domena;
using Blog.Models.Widoki;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages.Autor.Wpisy
{
    public class DodajWpisModel : PageModel
    {
        private readonly BlogDbContext blogDbContext;

        [BindProperty]
        public WidokDodajWpis DodajWpisRequest { get; set; }
        public DodajWpisModel(BlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }
        
        public void OnGet()
        {
        }
        public void OnPost()
        {
            var entry= new Entry()
            { 
                Title = DodajWpisRequest.Title,
                Text = DodajWpisRequest.Text,
                Date = DodajWpisRequest.Date, 
                Author = DodajWpisRequest.Author,
            
            };

            blogDbContext.Entries.Add(entry);
            blogDbContext.SaveChanges();
        }
    }
}
