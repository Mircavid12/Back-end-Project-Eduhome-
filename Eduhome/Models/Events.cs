using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Events
    {
        public int id { get; set; }
        [Required, StringLength(100)]
        public string Image { get; set; }
        public string Title { get; set; }
        public string Venue { get; set; }
        public DateTime? DeletedTime { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int Day { get; set; }
        public string Month { get; set; }
        public bool IsDeleted { get; set; }
        public EventDetails EventDetails { get; set; }
        
    }
}
