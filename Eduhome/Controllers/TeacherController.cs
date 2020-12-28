using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduhome.DAL;
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
        public IActionResult Index()
        {
            TeacherVM teacherVM = new TeacherVM
            {
                Teachers=_context.Teachers.Where(t=>t.IsDeleted==false).Include(t=>t.TeacherBios).ToList()
            };
            return View(teacherVM);
        }
        public IActionResult TeacherDetail()
        {
            TeacherVM teacherVM = new TeacherVM
            {
                Teachers = _context.Teachers.Where(t => t.IsDeleted == false).ToList(),
                TeacherDetails = _context.TeacherDetails.Where(td => td.IsDeleted == false).ToList(),
                TeacherBios = _context.teacherBios.ToList(),
                Skills = _context.Skills.ToList(),
                ContactInfos = _context.ContactInfos.ToList(),


            };
            return View(teacherVM);
        }
    }
}
