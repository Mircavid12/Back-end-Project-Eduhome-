﻿using System;
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
            ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Teachers.Where(t => t.IsDeleted == false).Include(tb => tb.TeacherBios).Count() / 4);
            ViewBag.page = page;
            if (page==null)
            {
                List<Teachers> teacherDetails = _context.Teachers.Where(t => t.IsDeleted == false).Include(tb => tb.TeacherBios).Take(4).ToList();
                return View(teacherDetails);
            }
            List<Teachers> teacherDetails1 = _context.Teachers.Where(t => t.IsDeleted == false).Include(tb=>tb.TeacherBios).Skip((int)(page-1)*4).Take(4).ToList();
            return View(teacherDetails1);
        }
        //Teacher Detail
        public IActionResult TeacherDetail(int? id)
        {
            if (id == null)
            {
                return View(_context.Teachers.Where(t => t.IsDeleted == false).Include(td => td.TeacherDetails).FirstOrDefault());
            }


            Teachers teachers = _context.Teachers.Where(t => t.IsDeleted == false).Include(td => td.TeacherDetails).ThenInclude(t => t.ContactInfos).Include(tb=>tb.TeacherBios).Include(ts=>ts.TeacherSkills).ThenInclude(s=>s.Skills).FirstOrDefault(t => t.id == id);
            if (teachers == null)
            {
                return NotFound();
            }
            return View(teachers);
        }
    }
}
