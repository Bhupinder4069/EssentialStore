using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EssentialStore.Models;

namespace EssentialStore.Data
{
    public class EssentialStoreContext : DbContext
    {
        public EssentialStoreContext (DbContextOptions<EssentialStoreContext> options)
            : base(options)
        {
        }

        public DbSet<EssentialStore.Models.Import> Import { get; set; }

        public DbSet<EssentialStore.Models.Sale> Sale { get; set; }

        public DbSet<EssentialStore.Models.Stock> Stock { get; set; }
    }
}
