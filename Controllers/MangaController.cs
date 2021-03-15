using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sendMail.Controllers
{
    public class MangaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
