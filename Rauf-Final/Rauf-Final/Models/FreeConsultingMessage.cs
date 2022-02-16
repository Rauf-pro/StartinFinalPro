using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Models
{
    public class FreeConsultingMessage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(2500)]
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("ServiceCategory")]
        public int ServiceCategoryID { get; set; }
        public ServiceCategory ServiceCategory { get; set; }
    }
}
