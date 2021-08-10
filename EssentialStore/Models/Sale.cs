using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EssentialStore.Models
{
    public class Sale
    {
        public int id { get; set; }

        [Display(Name = "Customer Name")]
        public string CName { get; set; }

        [Display(Name = "Product")]
        public string Product { get; set; }

        [Display(Name = "Qty")]
        public int Qty { get; set; }

        [Display(Name = "Price")]
        public int Price { get; set; }


        [Display(Name = "Billing")]
        public int BDate { get; set; }



    }
}
