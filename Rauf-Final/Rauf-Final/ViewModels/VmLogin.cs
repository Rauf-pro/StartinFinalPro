using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.ViewModels
{
    public class VmLogin
    {
        [MaxLength(15), Required]
        public string UserName { get; set; }

        [MaxLength(40), Required]
        public string Password { get; set; }
    }
}
