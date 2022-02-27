using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Product
    {
        #region Member

        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public int? Guarantee { get; set; }
        public int CategoryID { get; set; }
        public int? StoreID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { set; get; }
        [ForeignKey("StoreID")]
        public virtual Store Store { set; get; }

        public virtual List<PurInvoiceProducts> PurInvoiceProducts { set; get; }
        public virtual List<SalesInvoiceProducts> SalesInvoiceProducts { set; get; }


        #endregion
        #region Constructor

        public Product()
        {
            PurInvoiceProducts=new List<PurInvoiceProducts>();
            SalesInvoiceProducts=new List<SalesInvoiceProducts>();

        }
        #endregion
    }
}
