using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduhome.DAL;
using Eduhome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eduhome.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            EventVM eventVM = new EventVM
            {
                Events=_context.Events.Where(e=>e.IsDeleted==false).ToList(),
            };
            return View(eventVM);
        }
        public IActionResult EventDetail()
        {
            EventVM eventVM = new EventVM
            {
                Events = _context.Events.Where(e => e.IsDeleted == false).ToList(),
                EventDetails = _context.EventDetails.Where(ed => ed.IsDeleted == false).ToList(),
                Categories = _context.Categories.Where(c => c.IsDeleted == false).ToList(),
                LatestPosts = _context.LatestPosts.Where(l => l.IsDeleted == false).ToList(),
                Tags = _context.Tags.Where(t => t.IsDeleted == false).ToList(),
                Speakers = _context.Speakers.Where(s => s.IsDeleted == false).ToList()
            };
            return View(eventVM);
        }
    }
}
