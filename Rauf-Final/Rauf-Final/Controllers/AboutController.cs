using Microsoft.AspNetCore.Mvc;
using Rauf_Final.DATA;
using Rauf_Final.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly AppDbContext _context;
        public AboutUsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmAbout model = new VmAbout();
            model.AboutUs = _context.AboutUs.FirstOrDefault();
            model.Setting = _context.Settings.FirstOrDefault();
            

            return View(model);
        }
    }
}
