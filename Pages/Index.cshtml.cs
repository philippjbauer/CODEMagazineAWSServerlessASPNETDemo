using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDb.Data;

namespace MovieDb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MovieDbContext _context;

        public List<Movie> Movies = new List<Movie>();

        public IndexModel(MovieDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Movies = _context.Movies.ToList();
        }
    }
}
