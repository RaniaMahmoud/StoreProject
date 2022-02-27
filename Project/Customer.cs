using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50),Required]
        public string Name { get; set; }
        [MaxLength(11),Required]
        public string Phone { get; set; }
        [MaxLength,Required]
        public string Address { get; set; }
        public int SalesInvoiceID { get; set; }
        [ForeignKey("SalesInvoiceID")]
        public virtual ICollection<SalesInvoice>SalesInvoice { get; set; }
    }
}
