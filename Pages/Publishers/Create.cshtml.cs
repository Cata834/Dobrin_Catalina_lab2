﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dobrin_Catalina_lab2.Data;
using Dobrin_Catalina_lab2.Models;

namespace Dobrin_Catalina_lab2.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Dobrin_Catalina_lab2.Data.Dobrin_Catalina_lab2Context _context;

        public CreateModel(Dobrin_Catalina_lab2.Data.Dobrin_Catalina_lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publishr Publisher { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
