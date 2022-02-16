using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }
        [MaxLength(500)]
        public string Subject { get; set; }
        [MaxLength(3000)]
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
