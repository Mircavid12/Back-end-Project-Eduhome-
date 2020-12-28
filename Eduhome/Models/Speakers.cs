using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Speakers
    {
        public int id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public bool IsDeleted { get; set; }
        public int EventDetailsId { get; set; }
        public virtual EventDetails EventDetails { get; set; }
    }
}
