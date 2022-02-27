using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Store
    {
        #region Prop
        public int ID { set; get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        #endregion
        #region Collection Of Product
        public virtual List<Product> Products { get; set; }
        #endregion
        #region Constructor
        //public Store(string _name, string _address)
        //{
        //    Name = _name;
        //    Address = _address;
        //    Products = new List<Product>();

        //}
        public Store()
        {
            Products = new List<Product>();
        }

        #endregion
    }

}
