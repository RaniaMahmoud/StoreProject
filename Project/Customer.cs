using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public virtual SalesInvoice  SalesInvoice { get; set; }
    }
}
