using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM();

            homeVM.Sliders = await _context.Sliders.ToListAsync();
            homeVM.Features = await _context.Features.ToListAsync();

            return View(homeVM);
        }
    }
}
