using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduhome.DAL;
using Eduhome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eduhome.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ContactVM contactVM = new ContactVM
            {
                Contacts=_context.Contacts.Where(c=>c.isDeleted==false).ToList()
            };
            return View(contactVM);
        }
    }
}
