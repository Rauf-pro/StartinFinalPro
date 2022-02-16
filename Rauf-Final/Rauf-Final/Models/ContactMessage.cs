using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Models
{
    public class ContactMessage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(1500)]
        public string Subject { get; set; }
        [MaxLength(2500)]
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
