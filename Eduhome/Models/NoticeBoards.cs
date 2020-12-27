using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class NoticeBoards
    {
        public int Id { get; set; }
        [Required]
        public DateTime NoticeTime { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
