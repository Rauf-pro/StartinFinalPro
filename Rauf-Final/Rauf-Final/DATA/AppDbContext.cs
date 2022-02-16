using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rauf_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.DATA
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<AdvanteageOption> AdvanteageOptions { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CompaniesLogo> CompaniesLogos { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<FAQCategory> fAQCategories { get; set; }
        public DbSet<FreeConsultingMessage> FreeConsultingMessages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public DbSet<ServiceToAdvantage> ServiveToAdvantages { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagToBlog> TagToBlogs { get; set; }



















    }
}
