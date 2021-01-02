using Eduhome.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
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
        public DbSet<CourseFeatures> CourseFeatures { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<LatestPosts> LatestPosts { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<EventDetails> EventDetails { get; set; }
        public DbSet<Speakers> Speakers { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<BlogDetails> BlogDetails { get; set; }
        public DbSet<AboutIntro> AboutIntros { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<TeacherDetails> TeacherDetails { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<ContactInfos> ContactInfos { get; set; }
        public DbSet<TeacherBios> teacherBios { get; set; }
        public DbSet<AboutVideo> AboutVideos { get; set; }
        public DbSet<Contacts> Contacts { get; set; }

    }
}
