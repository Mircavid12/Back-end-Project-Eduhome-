using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Sliders
    {
        public int id { get; set; }
        [Required, StringLength(150)]
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        [Required,StringLength(100)]
        public string Image { get; set; }
        public bool IsDeleted { get; set; }

    }
}
