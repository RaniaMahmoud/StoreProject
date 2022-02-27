using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Supplier
    {
        [Key]
        public int ID { set; get; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        [MaxLength(11), MinLength(11), Required]
        public string Phone { get; set; }
        
        [MaxLength(50),Required]
        public string Address { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { set; get; }

        public Supplier()
        {
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
        }
    }
}
