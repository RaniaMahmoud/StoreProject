using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class SalesInvoice
    {
        [Key]
        public int ID { set; get; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime InvoiceDate { get; set; }
        [Required]
        public double Total { get; set; }
        public virtual Customer Customer { set; get; }
        //public List<ProductInfo> ProductsInfo  { get; set; }

        //public static int ID = 0;
        //public string Customer { get; set; }
        public SalesInvoice()
        {
            //ID++;
            InvoiceDate = DateTime.Now;
            //ProductsInfo = new List<ProductInfo>();
        }
    }
}
