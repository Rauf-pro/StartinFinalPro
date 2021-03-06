using Microsoft.AspNetCore.Identity;
using Rauf_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.ViewModels
{
    public class ViewModelUsers
    {
        public List<CustomUser> CustomUsers { get; set; }
        public List<IdentityRole> IdentityRoles { get; set; }
        public List<IdentityUserRole<string>> UserRoles { get; set; }
    }
}
