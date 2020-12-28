using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Teachers
    {
        public int id { get; set; }
        [Required, StringLength(100)]
        public string Image { get; set; }
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }
        public DateTime? DeletedTime { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<TeacherBios> TeacherBios { get; set; }
        public TeacherDetails TeacherDetails { get; set; }
        public int TeacherDetailsId { get; set; }
    }
}
