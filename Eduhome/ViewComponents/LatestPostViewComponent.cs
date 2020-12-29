using Eduhome.DAL;
using Eduhome.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewComponents
{
    public class LatestPostViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public LatestPostViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<LatestPosts> latestPosts = _context.LatestPosts.Where(lp => lp.IsDeleted == false).ToList();
            return View(await Task.FromResult(latestPosts));
        }
    }
}
