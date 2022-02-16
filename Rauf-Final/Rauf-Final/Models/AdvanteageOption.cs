using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Models
{
    public class AdvanteageOption
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }

    }
}
