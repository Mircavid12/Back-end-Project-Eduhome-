using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class LatestPosts
    {
        public int id { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(100)]
        public string Image { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        [ForeignKey("Courses")]
        public int CourseId { get; set; }
        public virtual Courses Courses { get; set; }
        [ForeignKey("Events")]
        public int EventId { get; set; }
        public virtual Events Events { get; set; }
        [ForeignKey("Blogs")]
        public int BlogId { get; set; }
        public virtual Blogs Blogs { get; set; }
    }
}
