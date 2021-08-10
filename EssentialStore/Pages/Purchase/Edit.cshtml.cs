using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EssentialStore.Data;
using EssentialStore.Models;

namespace EssentialStore.Pages.Purchase
{
    public class EditModel : PageModel
    {
        private readonly EssentialStore.Data.EssentialStoreContext _context;

        public EditModel(EssentialStore.Data.EssentialStoreContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Import).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImportExists(Import.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ImportExists(int id)
        {
            return _context.Import.Any(e => e.id == id);
        }
    }
}
