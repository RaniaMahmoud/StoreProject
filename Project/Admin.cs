using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Admin
    {
        [Key,Required,MaxLength(30)]
        public string UserName { get; set; }
        [Required,MaxLength(20)]
        public string Password { get; set; }
    }
}
