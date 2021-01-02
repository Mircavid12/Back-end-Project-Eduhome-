using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Courses
    {
        public int id { get; set; }
        [Required,StringLength(100)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DeletedTime { get; set; }
        public bool IsDeleted { get; set; }
        public CourseFeatures CourseFeatures { get; set; }
        public ICollection<Tags> Tags { get; set; }
        public ICollection<LatestPosts> LatestPosts { get; set; }
    }
}
