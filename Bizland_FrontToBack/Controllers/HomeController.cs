using Bizland_FrontToBack.DAL;
using Bizland_FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bizland_FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM home = new HomeVM
            {
                Intro = _context.Intro.ToList(),
            };
        return View(home);
       }
    }
}
