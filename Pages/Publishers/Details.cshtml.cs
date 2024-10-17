using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dobrin_Catalina_lab2.Data;
using Dobrin_Catalina_lab2.Models;

namespace Dobrin_Catalina_lab2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Dobrin_Catalina_lab2.Data.Dobrin_Catalina_lab2Context _context;

        public DetailsModel(Dobrin_Catalina_lab2.Data.Dobrin_Catalina_lab2Context context)
        {
            _context = context;
        }

        public Publishr Publisher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
