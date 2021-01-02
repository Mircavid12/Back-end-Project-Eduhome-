using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Eduhome.DAL;
using Eduhome.Extentions;
using Eduhome.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eduhome.Areas.EduAdmin.Controllers
{
    [Area("EduAdmin")]
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public EventController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Events.Where(e => e.IsDeleted == false).OrderByDescending(e => e.id).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Events events)
        {
            //if (!ModelState.IsValid)
            //{
            //    return NotFound();
            //}
            bool IsExist = _context.Events.Where(e => e.IsDeleted == false).Any(ed => ed.Title.ToLower() == events.Title.ToLower());
            if (IsExist)
            {
                ModelState.AddModelError("Title", "This event is already exist");
                return View();
            }
            if (events.Photo == null)
            {
                ModelState.AddModelError("", "Please add image");
                return View();
            }
            if (!events.Photo.IsImage())
            {
                ModelState.AddModelError("", "Please select image type");
                return View();
            }
            if (!events.Photo.MaxSize(250))
            {
                ModelState.AddModelError("", "Image size must be less than 250kb");
                return View();
            }
            string folder = Path.Combine("assets", "img", "event");
            string fileName = await events.Photo.SaveImageAsync(_env.WebRootPath, folder);
            events.Image = fileName;
            events.IsDeleted = false;

            await _context.Events.AddAsync(events);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Events events = _context.Events.Where(e => e.IsDeleted == false).Include(ed => ed.EventDetails).Include(et => et.Tags).FirstOrDefault(e => e.id == id);
            if (events == null) return NotFound();
            return View(events);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Events events = _context.Events.FirstOrDefault(e => e.id == id && e.IsDeleted == false);
            if (events == null) return NotFound();
            return View(events);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteEvent(int? id)
        {
            if (id == null) return NotFound();
            Events events = _context.Events.FirstOrDefault(e => e.id == id && e.IsDeleted == false);
            if (events == null) return NotFound();
            events.IsDeleted = true;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Events events = _context.Events.Include(e => e.EventDetails).Include(e => e.LatestPosts).Include(et => et.EventDetails).FirstOrDefault(e => e.id == id && e.IsDeleted == false);
            if (events == null) return NotFound();
            return View(events);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Events events, int? id)
        {
            Events viewEvent = _context.Events.Include(et => et.Tags).Include(e => e.LatestPosts).Include(ed=>ed.EventDetails)
                   .FirstOrDefault(e => e.id == id && e.IsDeleted == false);

            bool IsExist = _context.Events.Where(e => e.IsDeleted == false).Any(e => e.Title.ToLower() == events.Title.ToLower());

            if (IsExist && events.Photo == null)
            {
                ModelState.AddModelError("", "Please add image");
                return View(viewEvent);
            }

            if (events.Photo != null)
            {
                if (!events.Photo.IsImage())
                {
                    ModelState.AddModelError("", "Please select image type");
                    return View(viewEvent);
                }
                if (!events.Photo.MaxSize(250))
                {
                    ModelState.AddModelError("", "Image size must be less than 250kb");
                    return View(viewEvent);
                }

                string folder = Path.Combine("assets", "img", "event");
                string fileName = await events.Photo.SaveImageAsync(_env.WebRootPath, folder);
                viewEvent.Image = fileName;
            }
            viewEvent.Title = events.Title;
            events.IsDeleted = false;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
