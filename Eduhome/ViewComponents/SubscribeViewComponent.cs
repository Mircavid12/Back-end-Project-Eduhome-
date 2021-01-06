using Eduhome.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewComponents
{
    public class SubscribeViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public SubscribeViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await Task.FromResult(_context.Subscribes.FirstOrDefault()));
        }
    }
}
