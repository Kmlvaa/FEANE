using Feane.Data;
using Feane.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Feane.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Meal> meals = _context.Meals.ToList();
            return View(meals);
        }

    }
}