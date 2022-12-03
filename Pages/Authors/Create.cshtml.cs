﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Munteanu_Elena_Lab222.Data;
using Munteanu_Elena_Lab222.Models;

namespace Munteanu_Elena_Lab222.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Munteanu_Elena_Lab222.Data.Munteanu_Elena_Lab222Context _context;

        public CreateModel(Munteanu_Elena_Lab222.Data.Munteanu_Elena_Lab222Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
