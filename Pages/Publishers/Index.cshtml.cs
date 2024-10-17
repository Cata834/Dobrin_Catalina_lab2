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
    public class IndexModel : PageModel
    {
        private readonly Dobrin_Catalina_lab2.Data.Dobrin_Catalina_lab2Context _context;

        public IndexModel(Dobrin_Catalina_lab2.Data.Dobrin_Catalina_lab2Context context)
        {
            _context = context;
        }

        public IList<Publishr> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
