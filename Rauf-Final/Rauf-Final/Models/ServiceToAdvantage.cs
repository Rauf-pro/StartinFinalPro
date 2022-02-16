using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Models
{
    public class ServiceToAdvantage
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Service")]
        public int ServiceId { get; set; }
        [ForeignKey("Advantage")]
        public int AdvantageID { get; set; }
    }
}
