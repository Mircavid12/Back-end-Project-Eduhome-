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
        [HttpGet]
        public async Task<IActionResult> Index(string searchString,int? page)
        {
            ViewData["GetEvents"] = searchString;
            var eventQuery = from x in _context.Events select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                eventQuery = eventQuery.Where(x => x.Title.Contains(searchString) && x.IsDeleted == false);
                return View(await eventQuery.AsNoTracking().ToListAsync());
            }
            else
            {
                ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Events.Where(e => e.IsDeleted == false).Count() / 3);
                ViewBag.page = page;
                if (page == null)
                {
                    List<Events> eventDetails = _context.Events.Where(e => e.IsDeleted == false).Take(3).ToList();
                    return View(eventDetails);
                }
                List<Events> eventDetails1 = _context.Events.Where(e => e.IsDeleted == false).Skip((int)(page - 1) * 3).Take(3).ToList();
                return View(eventDetails1);
            }
        }
        public IActionResult EventDetail(int? id)
        {
            if (id == null)
            {
                return View(_context.Events.Where(e => e.IsDeleted == false).Include(ed => ed.EventDetails).FirstOrDefault());
            }
            

            Events events = _context.Events.Where(e => e.IsDeleted == false).Include(et => et.Tags).Include(ep => ep.LatestPosts).Include(ed => ed.EventDetails).Include(es=>es.EventSpeakers).ThenInclude(s=>s.Speakers).FirstOrDefault(e => e.id == id);
            if (events == null)
            {
                return NotFound();
            }
            return View(events);
        }
    }
}
