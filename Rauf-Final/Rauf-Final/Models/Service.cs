using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile MainImageFile { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(150)]
        public string AdvantegTitle { get; set; }
        [MaxLength(2000)]
        public string AdvantegContent { get; set; }
        [ForeignKey("ServiceCategory")]
        public int ServiceCategoryId { get; set; }
        public ServiceCategory ServiceCategory { get; set; }


    }
}
