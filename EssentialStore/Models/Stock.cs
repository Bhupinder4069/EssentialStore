using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EssentialStore.Models
{
    public class Stock
    {
        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Product")]
        public string Product { get; set; }

        [Display(Name = "Qty")]
        public int Qty { get; set; }

      public Import import { get; set; }

    }
}
