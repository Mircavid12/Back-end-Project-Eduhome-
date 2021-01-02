using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Speakers
    {
        public int id { get; set; }
        [Required, StringLength(100)]
        public string Image { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        public string Position { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<EventSpeaker> EventSpeakers { get; set; }
    }
}
