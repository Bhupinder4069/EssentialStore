using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EssentialStore.Data;
using EssentialStore.Models;

namespace EssentialStore.Pages.Purchase
{
    public class CreateModel : PageModel
    {
        private readonly EssentialStore.Data.EssentialStoreContext _context;

        public CreateModel(EssentialStore.Data.EssentialStoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Import Import { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Import.Add(Import);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
