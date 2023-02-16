using Microsoft.AspNetCore.Mvc;
using System;
using WidgetManagerProject.Data;
using WidgetManagerProject.Models;

namespace WidgetManagerProject.Controllers
{
    public class WidgetController : Controller
    {
        private readonly WidgetDbContext _context;

        public WidgetController(WidgetDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            var widgets = _context.Widgets.ToList();
            return View(widgets);
        }

        [HttpPost]
        
        public IActionResult Create(string widgetName, string widgetType)
        {
            // Use the input data to create a new Widget object
            Widget widget = new Widget
            {
                Name = widgetName,
                Type = widgetType,
                CreationDateTime = DateTime.Now
            };

            // Add the new Widget object to the database context
            _context.Widgets.Add(widget);
            _context.SaveChanges();

            // Redirect the user to the Index page
            return RedirectToAction(nameof(Index));
        }

    }
}
