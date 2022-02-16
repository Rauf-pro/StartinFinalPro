using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string SupTitle { get; set; }
        [MaxLength(250)]
        public string BgImage { get; set; }
        [NotMapped]
        public IFormFile BgImageFile { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Content { get; set; }
        [MaxLength(500)]
        public string Link { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
