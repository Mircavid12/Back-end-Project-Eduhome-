using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class TeacherDetails
    {
        public int id { get; set; }
        [Required, StringLength(100)]
        public string Image { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }
        public string Description { get; set; }
        public string Degree { get; set; }
        public string  Experience { get; set; }
        public string Hobbies { get; set; }
        public string Faculty { get; set; }
        public DateTime? DeletedTime { get; set; }
        public bool IsDeleted { get; set; }
        [ForeignKey("Teachers")]
        public int TeacherId { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}
