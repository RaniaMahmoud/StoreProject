using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class PurchaseInvoice : Invoice
    {
        [Key]
        public static int ID = 0;
        public virtual List<Product> Products { get; set; }
        public virtual string Supplier { get; set; }
        public PurchaseInvoice()
        {
            ID++;
            Products = new List<Product>();
        }
    }
}