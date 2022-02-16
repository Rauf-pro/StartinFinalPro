﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(25)]
        public string Icon { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Phone { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        [MaxLength(500)]
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [MaxLength(250)]
        public string BgImage { get; set; }
        [NotMapped]
        public IFormFile BgImageFile { get; set; }

    }
}
