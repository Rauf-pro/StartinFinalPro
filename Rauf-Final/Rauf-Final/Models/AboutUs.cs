using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Models
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string LeftImage { get; set; }
        [NotMapped]
        public IFormFile LeftImageFile { get; set; }
        [MaxLength(50)]
        public string RightSupTitle { get; set; }
        [MaxLength(150)]
        public string RightTitle { get; set; }
        [MaxLength(2500)]
        public string RightContent { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(250)]
        public string BgImage { get; set; }
        [NotMapped]
        public IFormFile BgImageFile { get; set; }
    }
}
