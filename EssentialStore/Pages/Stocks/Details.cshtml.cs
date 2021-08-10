using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EssentialStore.Data;
using EssentialStore.Models;

namespace EssentialStore.Pages.Stocks
{
    public class DetailsModel : PageModel
    {
        private readonly EssentialStore.Data.EssentialStoreContext _context;

        public DetailsModel(EssentialStore.Data.EssentialStoreContext context)
        {
            _context = context;
        }

        public Stock Stock { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Stock = await _context.Stock.FirstOrDefaultAsync(m => m.id == id);

            if (Stock == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
