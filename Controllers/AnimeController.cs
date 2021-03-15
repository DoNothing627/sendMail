using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sendMail.Models;

namespace sendMail.Controllers
{
    public class AnimeController : Controller
    {
        public IActionResult Index()
        {

            var anime = new List<Anime>
            {
                new Anime{name= "naruto"},
                new Anime{name= "one piece"}
            };

            var view = new ListAnime { Anime = anime };

            return View(view);
        }
    }
}
