using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Models
{
    public class FAQ
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        [MaxLength(1500)]
        public string Content { get; set; }

    }
}
