using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EssentialStore.Data;
using EssentialStore.Models;

namespace EssentialStore.Pages.Purchase
{
    public class DeleteModel : PageModel
    {
        private readonly EssentialStore.Data.EssentialStoreContext _context;

        public DeleteModel(EssentialStore.Data.EssentialStoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Import Import { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Import = await _context.Import.FirstOrDefaultAsync(m => m.id == id);

            if (Import == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Import = await _context.Import.FindAsync(id);

            if (Import != null)
            {
                _context.Import.Remove(Import);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
