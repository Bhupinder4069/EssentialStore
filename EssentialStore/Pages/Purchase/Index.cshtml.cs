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
    public class IndexModel : PageModel
    {
        private readonly EssentialStore.Data.EssentialStoreContext _context;

        public IndexModel(EssentialStore.Data.EssentialStoreContext context)
        {
            _context = context;
        }

        public IList<Import> Import { get;set; }

        public async Task OnGetAsync()
        {
            Import = await _context.Import.ToListAsync();
        }
    }
}
