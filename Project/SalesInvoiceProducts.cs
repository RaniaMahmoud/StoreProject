using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class SalesInvoiceProducts
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int SalesInvoiceID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
        [ForeignKey("SalesInvoiceID")]
        public virtual SalesInvoice SalesInvoice { set; get; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
