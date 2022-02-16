using Rauf_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.ViewModels
{
    public class VmBlog:VmLayout
    {
        public List<Blog> Blogs { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
