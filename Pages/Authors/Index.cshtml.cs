using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Munteanu_Elena_Lab222.Data;
using Munteanu_Elena_Lab222.Models;

namespace Munteanu_Elena_Lab222.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Munteanu_Elena_Lab222.Data.Munteanu_Elena_Lab222Context _context;

        public IndexModel(Munteanu_Elena_Lab222.Data.Munteanu_Elena_Lab222Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Author != null)
            {
                Author = await _context.Author.ToListAsync();
            }
        }
    }
}
