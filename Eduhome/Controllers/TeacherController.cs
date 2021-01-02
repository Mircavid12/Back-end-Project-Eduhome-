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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? page)
        {
            ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Teachers.Where(t => t.IsDeleted == false).Count() / 4);
            ViewBag.page = page;
            if (page==null)
            {
                List<Teachers> teacherDetails = _context.Teachers.Where(t => t.IsDeleted == false).Take(4).ToList();
                return View(teacherDetails);
            }
            List<Teachers> teacherDetails1 = _context.Teachers.Where(t => t.IsDeleted == false).Skip((int)(page-1)*4).Take(4).ToList();
            return View(teacherDetails1);
        }
        public IActionResult TeacherDetail(int? id)
        {
            if (id == null)
            {
                return View(_context.Teachers.Where(t => t.IsDeleted == false).Include(td => td.TeacherDetails).FirstOrDefault());
            }


            Teachers teachers = _context.Teachers.Where(t => t.IsDeleted == false).Include(td => td.TeacherDetails).Include(t=>t.ContactInfos).Include(tb=>tb.TeacherBios).FirstOrDefault(t => t.id == id);
            if (teachers == null)
            {
                return NotFound();
            }
            return View(teachers);
        }
    }
}
