using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Munteanu_Elena_Lab222.Data;
using Munteanu_Elena_Lab222.Models;

namespace Munteanu_Elena_Lab222.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Munteanu_Elena_Lab222.Data.Munteanu_Elena_Lab222Context _context;

        public DetailsModel(Munteanu_Elena_Lab222.Data.Munteanu_Elena_Lab222Context context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
