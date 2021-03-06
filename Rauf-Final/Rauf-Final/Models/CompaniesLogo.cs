using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Models
{
    public class CompaniesLogo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string LogoImage { get; set; }
        [NotMapped]
        public IFormFile LogoImageFile { get; set; }
        [MaxLength(500)]
        public string Link { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
