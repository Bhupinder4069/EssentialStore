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
    public class IndexModel : PageModel
    {
        private readonly EssentialStore.Data.EssentialStoreContext _context;

        public IndexModel(EssentialStore.Data.EssentialStoreContext context)
        {
            _context = context;
        }

        public IList<Stock> Stock { get;set; }

        public async Task OnGetAsync()
        {
            Stock = await _context.Stock.ToListAsync();
        }
    }
}
