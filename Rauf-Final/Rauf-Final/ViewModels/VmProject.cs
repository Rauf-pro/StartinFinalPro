
using Rauf_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.ViewModels
{
    public class VmProject:VmLayout
    {
        public List<Project> Projects { get; set; }
        public List<ProjectCategory> ProjectCategories { get; set; }
        public List<ProjectPhoto> ProjectPhotos { get; set; }
    }
}
