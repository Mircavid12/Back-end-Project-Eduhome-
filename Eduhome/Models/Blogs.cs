using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Blogs
    {
        public int id { get; set; }
        [Required, StringLength(100)]
        public string Image { get; set; }
        public string Info { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime? DeletedTime { get; set; }
        public bool IsDeleted { get; set; }
        public BlogDetails BlogDetails { get; set; }
        public int BlogDetailsId { get; set; }
    }
}
