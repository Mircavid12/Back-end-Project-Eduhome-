using Eduhome.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<NoticeBoards> NoticeBoards { get; set; }
        public DbSet<SingleNoticeRight> SingleNoticeRights { get; set; }
        public DbSet<Chooses> Chooses { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<CourseDetails> CourseDetails { get; set; }
        public DbSet<CourseFeatures> CourseFeatures { get; set; }
        public DbSet<Categories> Categories { get; set; }

    }
}
