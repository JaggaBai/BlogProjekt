using Blog.Data;
using Blog.Models.Domena;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages.Autor.Wpisy
{
    public class PublikacjeModel : PageModel
    {
        private readonly BlogDbContext blogDbContext;

        public List<Entry> Lista { get; set; }

        public PublikacjeModel(BlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }
        public void OnGet()
        {
           Lista = blogDbContext.Entries.ToList();
        }
    }
}
