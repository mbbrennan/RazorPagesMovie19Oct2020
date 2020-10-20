using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie19Oct2020.Models;

namespace RazorPagesMovie19Oct2020.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie19Oct2020.Models.RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovie19Oct2020.Models.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
