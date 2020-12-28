using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class BlogDetails
    {
        public int id { get; set; }
        [Required,StringLength(100)]
        public string Image { get; set; }
        [Required]
        public string Info { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public DateTime? DeletedTime { get; set; }
        public bool IsDeleted { get; set; }
        [ForeignKey("Blogs")]
        public int BlogsId { get; set; }
        public virtual Blogs Blogs { get; set; }
    }
}
