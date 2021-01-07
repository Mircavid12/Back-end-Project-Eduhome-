using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
        #region Create
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Events events)
        {
            
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
            List<Subscribe> emails = _context.Subscribes.ToList();
            foreach (Subscribe email in emails)
            {
                SendEmail(email.Email, "Yeni bir event yaradildi.", "Yeni bir event yaradildi");
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Detail
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Events events = _context.Events.Where(e => e.IsDeleted == false).Include(ed => ed.EventDetails).Include(et => et.Tags).FirstOrDefault(e => e.id == id);
            if (events == null) return NotFound();
            return View(events);
        }
        #endregion

        #region Delete
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
        #endregion

        #region Update
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
            Events viewEvent = _context.Events.Include(et => et.Tags).Include(e => e.LatestPosts).Include(ed => ed.EventDetails)
                   .FirstOrDefault(e => e.id == id && e.IsDeleted == false);



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
        #endregion
        
        
        #region SubscribeArea
        public void SendEmail(string email, string subject, string htmlMessage)
        {
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "miri.elekberov.code@gmail.com",
                    Password = "mustafa2001"
                }
            };
            MailAddress fromEmail = new MailAddress("miri.elekberov.code@gmail.com", "Miri");
            MailAddress toEmail = new MailAddress(email, "Miri");
            MailMessage message = new MailMessage()
            {
                From = fromEmail,
                Subject = subject,
                Body = htmlMessage
            };
            message.To.Add(toEmail);
            client.Send(message);
        }
        #endregion

    }
}
