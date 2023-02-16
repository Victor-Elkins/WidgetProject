using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WidgetManagerProject.Data;
using WidgetManagerProject.Models;

namespace WidgetManagerProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly WidgetDbContext _context;

        public HomeController(WidgetDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Widget widget)
        {
            if (ModelState.IsValid)
            {
                _context.Widgets.Add(widget);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Success));
            }
            return View(widget);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
