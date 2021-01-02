using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduhome.DAL;
using Eduhome.Models;
using Eduhome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult EventDetail(int? id)
        {
            if (id == null)
            {
                return View(_context.Events.Where(e => e.IsDeleted == false).Include(ed => ed.EventDetails).FirstOrDefault());
            }
            

            Events events = _context.Events.Where(e => e.IsDeleted == false).Include(et => et.Tags).Include(ep => ep.LatestPosts).Include(ed => ed.EventDetails).Include(es=>es.EventSpeakers).FirstOrDefault(e => e.id == id);
            if (events == null)
            {
                return NotFound();
            }
            return View(events);
        }
    }
}
