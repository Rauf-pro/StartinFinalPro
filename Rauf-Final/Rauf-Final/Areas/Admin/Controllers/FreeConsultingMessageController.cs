using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rauf_Final.Areas.Admin.Controllers
{
    public class FreeConsultingMessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
