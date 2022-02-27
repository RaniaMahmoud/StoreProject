using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class PurInvoiceProducts
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int PurchaseInvoiceID { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Guarantee { get; set; }
        [ForeignKey("PurchaseInvoiceID")]
        public virtual PurchaseInvoice PurchaseInvoice { set; get; }
        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
        

    }
}
