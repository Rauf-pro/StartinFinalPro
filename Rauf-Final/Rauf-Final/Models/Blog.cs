using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile MainImageFile { get; set; }
        public string Content { get; set; }
        [ForeignKey("BlogCategory")]
        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }
        [ForeignKey("Comment")]
        public int CommentId { get; set; }
        public Comment Comment { get; set; }

    }
}
