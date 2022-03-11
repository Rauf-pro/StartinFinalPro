using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Models
{
    public class ServiceCategory
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Icon { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string ShortContent { get; set; }
        public List<Service> Services { get; set; }


    }
}
