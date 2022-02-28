using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Category
    {
        #region Prop
        public int ID { set; get; }
        [Required]
        public string Name { get; set; }
        #endregion
        #region Collection Of Product
        public virtual List<Product> Products { get; set; }
        #endregion
        #region Constructor
        public Category()
        {
            Products = new List<Product>();
        }
        public Category(string _name)
        {
            Name = _name;
            Products = new List<Product>();
        }
        #endregion
    }
}