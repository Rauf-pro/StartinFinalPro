using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500)]
        public string HeadTitle { get; set; }
        [MaxLength(200)]
        public string LeftTitle { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(150)]
        public string ClientFullName { get; set; }
        public string RightContent { get; set; }
        [MaxLength(500)]
        public string GoToLink { get; set; }
        [MaxLength(150)]
        public string CategoryTitle { get; set; }
        [MaxLength(2500)]
        public string CategoryContent { get; set; }
        [MaxLength(1000)]
        public string Award { get; set; }
        [ForeignKey("ProjectCategory")]
        public int ProjectCategoryId { get; set; }
        public ProjectCategory ProjectCategory { get; set; }
        [ForeignKey("ProjectPhoto")]
        public int ProjectPhotoId { get; set; }
        public ProjectPhoto ProjectPhoto { get; set; }




    }
}
